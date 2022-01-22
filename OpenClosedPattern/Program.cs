using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalaryAccount salaryAccount = new SalaryAccount() { Balance = 5000 };
            UsualAccount usualAccount = new UsualAccount() { Balance = 999 };

            Console.WriteLine(salaryAccount.ToString());
            Console.WriteLine(usualAccount.ToString());

            Calculator.CalculateInterest(salaryAccount);
            Calculator.CalculateInterest(usualAccount);

            Console.WriteLine();
            Console.WriteLine(salaryAccount.ToString());
            Console.WriteLine(usualAccount.ToString());

            Console.ReadKey();


        }
    }
}
