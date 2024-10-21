using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Hewan
    {
        public string Nama { get; set; }
        public string WarnaKulit { get; set; }

        public void Bernafas()
        {
            Console.WriteLine(Nama + " sedang bernafas....");
        }
        public abstract void Suara();
    }
}
