using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Constructer
{
    internal class Anjing : Hewan
    {
        public Anjing(string nama, string warnaKulit) : base(nama, warnaKulit)
        {
        }
    }
}
