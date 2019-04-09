using RepositoryOfXA.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfXA.Dal
{
    public class OperatorDataContext: DbContext
    {
        public OperatorDataContext()
           : base("OperatorDataContext")
        {

        }
        public DbSet<Operator> Operator { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(OperatorDataContext).Assembly);
        }

    }
}
