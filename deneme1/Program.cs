using System;

namespace deneme1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrencisayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolardün = 7.45;
            double dolarbugün = 7.45;

            if (dolardün>dolarbugün)
            {
                Console.WriteLine("Azalıs butonu");
            }
            else if(dolardün<dolarbugün)
            {
                Console.WriteLine("Aartış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }



            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);


            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
