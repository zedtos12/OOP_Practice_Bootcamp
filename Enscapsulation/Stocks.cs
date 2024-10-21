using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enscapsulation
{
    internal class Stocks : Saving
    {
        public double test()
        {
            Stocks stock1 = new Stocks();
            stock1.interestRate = 0.1;

            return stock1.interestRate;
        }
    }
}
