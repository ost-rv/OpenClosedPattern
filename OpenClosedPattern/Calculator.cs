using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPattern
{
    internal static class Calculator
    {
        public static void CalculateInterest(IAccountInterest account)
        { 
            account.CalculateInterest();
        }
    }
}
