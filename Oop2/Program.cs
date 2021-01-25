using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMüsteri müsteri1 = new GercekMüsteri();
            müsteri1.Id = 1;
            müsteri1.MusteriNo = "12345";
            müsteri1.Adi = "Deniz";
            müsteri1.Soyadi = "Aslan";
            müsteri1.TcNo = "123456456";

            TüzelMüsteri müsteri2 = new TüzelMüsteri();
            müsteri2.Id = 2;
            müsteri2.MusteriNo = "54321";
            müsteri2.SirketAdi = "Aslan Maden";
            müsteri2.VergiNo = "1234567890";


            Müsteri müsteri3 = new GercekMüsteri();
            Müsteri müsteri4 = new TüzelMüsteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(müsteri1);
            musteriManager.Add(müsteri2);

        }
    }
}
