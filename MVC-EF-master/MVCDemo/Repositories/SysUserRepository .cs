using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo.ViewModels;
using MVCDemo.DAL;

namespace MVCDemo.Repositories
{
    public class SysUserRepository : ISysUserRepository
    {
        protected AccountContext db = new AccountContext();
        public void Add(SysUser sysUser)
        {
            db.SysUsers.Add(sysUser);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = db.SysUsers.FirstOrDefault(u => u.ID == id);
            if (user != null)
            {
                db.SysUsers.Remove(user);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public IQueryable<SysUser> SelectAll()
        {
            return db.SysUsers;
        }

        public SysUser SelectByName(string userName)
        {
            return db.SysUsers.FirstOrDefault(u => u.UserName == userName);
        }
    }
}