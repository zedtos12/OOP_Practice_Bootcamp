using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Constructer
{
    internal class Hewan
    {
        public string Nama { get; set; }
        public string WarnaKulit { get; set; }

        public Hewan(string nama, string warnaKulit)
        {
            Nama = nama;
            WarnaKulit = warnaKulit;
        }

        public void Suara()
        {
            Console.WriteLine(Nama + " Bersuara");
        }
    }
}
