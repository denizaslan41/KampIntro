using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlara
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);
        }

        public void Ekle2(string urunAdi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi)
        }
    }
}
