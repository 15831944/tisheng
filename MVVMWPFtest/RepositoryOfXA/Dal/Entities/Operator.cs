using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfXA.Dal.Entities
{
     public class Operator
    {
        public int Ope_Id { get; set; }
        public string Ope_Name { get; set; }
        public int Ope_Ifuse { get; set; }
       public string Ope_Account { get; set; }
        public string Ope_PassWord { get; set; }
    }
}
