using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Kucing : Hewan
    {
        public override void Suara()
        {
            Console.WriteLine("Meow....");
        }
    }
}
