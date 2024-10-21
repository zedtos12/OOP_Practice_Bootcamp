using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice_Bootcamp_ClassAndObject.Class
{
    internal class Mobil
    {
        public int DiameterBan { get; set; }
        public string Warna { get; set; }
        public string Merk { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Mobil dinyalakan");
        }

        public void StopEngine()
        {
            Console.WriteLine("Mobil dimatikan");
        }

        public void Sound()
        {
            Console.WriteLine("Brummm.....");
        }
    }
}
