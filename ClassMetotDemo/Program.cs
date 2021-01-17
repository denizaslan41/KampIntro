using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1001;
            musteri1.Ad = "Deniz";
            musteri1.Soyad = "Aslan";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1002;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demirog";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine("------------------------");

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Gizlilik();

        }

    }
}
