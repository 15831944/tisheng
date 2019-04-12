using MVCDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo.DAL
{
    public class AccountInitializer:DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            var sysUsers = new List<SysUser>
            {
                new SysUser {UserName="jon",Password="1" }

            };
            sysUsers.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();
            var sysRoles = new List<SysRole>
                {
                new SysRole {RoleName="zjp",RoleDesc="nskl/fnsf",TestWord="Y" },
                new SysRole {RoleName="dss",RoleDesc="nskl/fndsdsf",TestWord="Y"},

            };
            sysRoles.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();
        }
    }
}