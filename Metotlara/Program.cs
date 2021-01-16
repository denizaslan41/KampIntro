﻿using System;

namespace Metotlara
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("-----------Metotlar---------");

            SepetManager sepetmenegar = new SepetManager();
            sepetmenegar.Ekle(urun1);
            sepetmenegar.Ekle(urun2);

            sepetmenegar.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetmenegar.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetmenegar.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 10);
        }
    }
}


//Dont repeat yourself - DRY - Clean Code - BEst Pratice