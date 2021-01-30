using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " " + "Eklendi");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " " + musteri.MusteriYas + " " + "Listelendi");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi ");
        }


    }
}
