// See https://aka.ms/new-console-template for more information

using OOP_Practice_Bootcamp_ClassAndObject.Class;
using System.Diagnostics.Contracts;

Console.WriteLine("Hello, World!");
Console.WriteLine();    

Mobil mobil = new Mobil();

mobil.DiameterBan = 20;
mobil.Warna = "Merah";
mobil.Merk = "Toyota";

Console.WriteLine(mobil.DiameterBan);
Console.WriteLine(mobil.Warna);
Console.WriteLine(mobil.Merk);

//jangan lupa tambahkan banyak object selain mobil

