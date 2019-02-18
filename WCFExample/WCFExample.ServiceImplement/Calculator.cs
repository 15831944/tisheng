using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFExamle.ServiceInterface;

namespace WCFExample.ServiceImplement
{
    public class Calculator : ICalculator
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
