using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enscapsulation
{
    internal class Saving
    {
        private double balance;
        protected double interestRate;

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public double getBalance()
        {
            return balance;
        }

        //public double Balance
        //{
        //    get { return balance; }
        //    set { balance = value; }
        //}

        //public double Balance2 { get; set; }
    }
}
