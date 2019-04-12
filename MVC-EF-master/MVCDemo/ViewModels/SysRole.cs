using System.Collections.Generic;

namespace MVCDemo.ViewModels
{
    public class SysRole
    {
        public int ID { set; get; }
        public string RoleName { set; get; }
        public string  RoleDesc { set; get; }
        public string TestWord { get; set; }
        public ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}