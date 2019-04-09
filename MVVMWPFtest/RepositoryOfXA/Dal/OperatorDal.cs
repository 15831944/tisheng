using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryOfXA.Dal.Entities;

namespace RepositoryOfXA.Dal
{
  public class OperatorDal
    {
        OperatorDataContext opd = new OperatorDataContext();
        public List<Operator> GetAllUser()
        {
            return opd.Operator.ToList();
        }
        public void Insert(Operator Operator)
        {
            opd.Operator.Add(Operator);
            opd.SaveChanges();
        }
        public void Delete(Operator Operator)
        {
            opd.Operator.Remove(Operator);
            opd.SaveChanges();
        }
        public void Update(Operator Operator)
        {
            var id = opd.Operator.Find(Operator.Ope_Id);
            var entry = opd.Entry(id);
            entry.CurrentValues.SetValues(Operator);
            entry.Property(p => p.Ope_Id).IsModified = false;
            opd.SaveChanges();
        }
    }
}
