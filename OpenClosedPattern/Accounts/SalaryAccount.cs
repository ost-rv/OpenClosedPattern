using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPattern
{
    internal class SalaryAccount : Account, IAccountInterest
    {
        public void CalculateInterest()
        {
            this.Interest = this.Balance * 0.5;
        }

        public override string ToString()
        {
            return "Зарплатный:\n" + base.ToString();
        }
    }
}
