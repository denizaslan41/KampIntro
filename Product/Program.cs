using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalem Kalem1 = new Kalem();
            Kalem1.KalemAdi = "Kalem 1";
            Kalem1.adet = "10";
            Kalem1.fiyati = 50;


            Kalem Kalem2 = new Kalem();
            Kalem2.KalemAdi = "Kalem 2";
            Kalem2.adet = "100";
            Kalem2.fiyati = 100;


            Kalem Kalem3 = new Kalem();
            Kalem3.KalemAdi = "0.3 Kalem";
            Kalem3.adet = "1000";
            Kalem3.fiyati = 250;


            //Console.WriteLine(Kalem1.KalemAdi + " : " + Kalem1.Egitmen);

            Kalem[] Kalemlar = new Kalem[] { Kalem1, Kalem2, Kalem3 };

            foreach (var Kalem in Kalemlar)
            {
                Console.WriteLine(Kalem.KalemAdi + " : " + Kalem.adet);
            }

        }
    }

    class Kalem
    {
        public string KalemAdi { get; set; }
        public string adet { get; set; }
        public int fiyati { get; set; }
    }
}