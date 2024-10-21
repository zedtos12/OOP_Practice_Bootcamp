// See https://aka.ms/new-console-template for more information

using Inheritance_Constructer;

Kucing kucingPertama = new Kucing("Kucing 1", "Merah");
Anjing anjingPertama = new Anjing("Anjing 1", "Kuning");

Console.WriteLine("Nama : " + kucingPertama.Nama);
Console.WriteLine("Warna : " + kucingPertama.WarnaKulit);
kucingPertama.Suara();

Console.WriteLine();

Console.WriteLine("Nama : " + anjingPertama.Nama);
Console.WriteLine("Warna : " + anjingPertama.WarnaKulit);
anjingPertama.Suara();

if (kucingPertama is Hewan)
{
    Console.WriteLine("Kucing adalah hewan");
}

//jangan lupa ajarin overiding method
//dan tambahkan fungsi special di kucing dan anjing 