using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi1 = "Elma";
            double fiyati1 = 15;
            string aciklama1 = "Amasya Elması";

            string urunAdi2 = "Çilek";
            double fiyati2 = 10;
            string aciklama2 = "Çilek Gibi Çilek";

            string[] meyveler = new string[] {urunAdi1,urunAdi2 };


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };


            // type - safe -- tip güvenli
            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");

            }



            Console.WriteLine("-----------------------------Metotlar------------");

            //insyance - örnek
            //encapsulation

            SeperManager seperManager = new SeperManager();
            seperManager.Ekle(urun1);
            seperManager.Ekle(urun2);

            seperManager.Ekle2("Armut", "Yeşil armut", 12,10);
            seperManager.Ekle2("Elma", "Yeşil elma", 12,9);
            seperManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);

        }
    }
}