// See https://aka.ms/new-console-template for more information

//Jelaskan kenapa abstract class tidak bisa di instansiasi

using Abstraction;

Kucing kucing = new Kucing();
kucing.Nama = "Kucing";
kucing.WarnaKulit = "Putih";
kucing.Bernafas();
Console.WriteLine("Nama: " + kucing.Nama);
Console.WriteLine("Warna Kulit: " + kucing.WarnaKulit);
kucing.Suara();


