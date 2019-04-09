using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using RepositoryOfXA.Dal.Entities;

namespace RepositoryOfXA.Dal
{
    public class OperatorInitializer : DropCreateDatabaseIfModelChanges<OperatorDataContext>
    {
        protected override void Seed(OperatorDataContext context)
        {
            var sysUsers = new List<Operator>
            {
                new Operator
                {
                    Ope_Account ="jon",Ope_PassWord="1",Ope_Ifuse=1,Ope_Name="许相超"

                }

            };
            sysUsers.ForEach(s => context.Operator.Add(s));
            context.SaveChanges();
        }
    }
}
