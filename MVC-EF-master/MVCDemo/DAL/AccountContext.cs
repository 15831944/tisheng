using MVCDemo.ViewModels;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCDemo.DAL
{
    public class AccountContext:DbContext
    {
       
        public AccountContext():base("AccountContext")
        {

        }
        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<SysRole>SysRoles { get; set; }
        public DbSet<SysUserRole> SysUserRoles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}