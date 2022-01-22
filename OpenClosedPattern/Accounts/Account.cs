using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPattern
{
    internal abstract class Account
    {
        // баланс 
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public override string ToString()
        {
            return $"Баланс: {Balance:N2}; Ставка: {Interest:N2}";
        }
    }
}
