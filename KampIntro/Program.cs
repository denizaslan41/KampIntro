using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
               //  type safety - tip güvenligi
               // Do not repeat yourself - Kendini tekrarlama
               //true = olumlu 
               //false = olumsuz

            string kategoriEtiketi = "Kategori";
            int ogrencisayısı = 32000;
            double faizOrani = 1.45;
            bool sistemegirisyapmismi = true;
            double dolardun = 7.35;
            double dolarbugun = 7.45;

            if (dolardun > dolarbugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolardun < dolarbugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemegirisyapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}