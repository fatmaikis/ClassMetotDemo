using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAd = "Fatma";
            musteri1.MusteriSoyad = "Ikış";
            musteri1.MusteriYas = 21;

            //Musteri musteri2 = new Musteri();
            //musteri2.MusteriAd = "Esra";
            //musteri2.MusteriSoyad = "Ikış";
            //musteri2.MusteriYas = 24;

            Musteri musteri2 = new Musteri { MusteriAd = "Esra", MusteriSoyad = "Ikış", MusteriYas = 24 };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2};


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı: " + musteri.MusteriAd);
                Console.WriteLine("Müşteri Soyadı: " + musteri.MusteriSoyad);
                Console.WriteLine("Müşteri Yaşı: " + musteri.MusteriYas);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Listele(musteri1);
            musteriManager1.Listele(musteri2);

            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager2.Silme(musteri1);
            musteriManager2.Silme(musteri2);





        }
    }
}
