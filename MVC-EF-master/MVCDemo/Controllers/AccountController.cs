using MVCDemo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.ViewModels;
using System.Data.Entity;

namespace MVCDemo.Controllers
{
    public class AccountController : Controller
    {
        private AccountContext db = new AccountContext();
        // GET: Account
        public ActionResult Index()
        {
            return View(db.SysUsers);
        }
        private UnitOfWork uow = new UnitOfWork();
        public ActionResult SelectAll()
        {
            int pageIndex = Request["page"] == null ? 1 : int.Parse(Request["page"]);
            int pageSize = Request["rows"] == null ? 10 : int.Parse(Request["rows"]);
            int total = 0;
            var temp = db.SysUsers;
            total = temp.Count();
            var users = uow.SysUserRepository.Get(orderBy:q => q.OrderBy(u => u.UserName));
            var data = new
            {
                total = total,
                rows = users.ToList<SysUser>()
            };
            return Json(data);
        }
        public ActionResult AddUser(SysUser sysUser)
        {
            try
            {
                uow.SysUserRepository.Insert(sysUser);
                uow.Save();
                return Content("OK");
            }
            catch (Exception EX)
            {
                return Content(EX.Message);
            }
           
           
        }
        public ActionResult Select()
        {
            return View(db.SysUsers);
        }
        public ActionResult Edit(int id)
        {
            SysUser sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }

        [HttpPost]
        public ActionResult Edit(SysUser sysUser)
        {
            db.Entry(sysUser).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        

         //删除用户

       public ActionResult Delete(int id)
        {
            SysUser sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }

        [HttpPost, ActionName("Delete")]

        public ActionResult DeleteConfirmed(int id)

        {

            SysUser sysUser = db.SysUsers.Find(id);

            db.SysUsers.Remove(sysUser);

            db.SaveChanges();

            return RedirectToAction("Index");

        }
        //新建用户

        public ActionResult Create()

        {

            return View();

        }

        [HttpPost]

        public ActionResult Create(SysUser sysUser)

        {

            db.SysUsers.Add(sysUser);

            db.SaveChanges();

            return RedirectToAction("Index");

        }
        public ActionResult Login()
        {
            ViewBag.LoginState = "登录前";
            return View();
        }
        public ActionResult Details(int id)
        {
            SysUser sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string name = fc["exampleInputname"];
            string password = fc["exampleInputPassword1"];
            var user = db.SysUsers.Where(b=>b.UserName == name & b.Password == password);
          
            if(user.Count()>0)
            {
                 ViewBag.LoginState = name + "  +"+password + "登录后";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.LoginState = "用户不存在...";
                return View();
            }
         
        }
        public ActionResult Register()
        {
            ViewBag.register = "注册前。。。";
            return View();
        }

        [HttpPost]
        public ActionResult Register(FormCollection fc)
        {
           
            string name = fc["name"];
            string age = fc["age"];
            ViewBag.register = name + "+" + age;
            return View();
        }
        [HttpPost]
        public ActionResult EFUpdateDemo()
        {
            var SysUser = db.SysUsers.FirstOrDefault(u => u.UserName == "Join");
            if (SysUser!=null)
            {
                SysUser.UserName = "Tom2";
            }
            db.SaveChanges();
            return View();
        }
        [HttpPost]
        public ActionResult EFAddOrDeleteDemo()
        {
            var newSysUser = new SysUser()

            {

                UserName = "Scott",

                Password = "tiger",

                Email = "Scott@sohu.com"

            };

            db.SysUsers.Add(newSysUser);
            db.SaveChanges();
            return View();
        }
    }
}