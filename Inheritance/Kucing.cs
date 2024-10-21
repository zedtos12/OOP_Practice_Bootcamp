using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Constructer
{
    internal class Kucing : Hewan
    {
        public Kucing(string nama, string warnaKulit) : base(nama, warnaKulit)
        {
        }
    }
}
