using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım kursu";
            string kurs2 = "programlamaya giriş";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            // array - dizi

            string[] kurslar = new string[] { "Yazılım kursu", "programlamaya giriş", "Java" , "Python","C#"};

                                        //Length - eleman demek
            for (int i = 0; i < kurslar.Length; i++) //i birer arttırmak için ullanılıyor
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Syfa Sonu - footer");
        }
    }
}
