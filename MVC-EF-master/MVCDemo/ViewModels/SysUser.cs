using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.ViewModels
{
    public class SysUser
    {
        public int ID { set; get; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}