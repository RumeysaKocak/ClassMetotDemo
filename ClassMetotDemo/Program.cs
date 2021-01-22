using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAd = "Rumeysa";
            musteri1.MusteriSoyad = "Koçak";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 3;
            musteri2.MusteriAd = "Yavuz";
            musteri2.MusteriSoyad = "Kalkan";

            Musteri[] musteri = new Musteri[] { musteri1, musteri2 };

            for (int i = 0; i < musteri.Length; i++)
            {
                Console.Write(musteri[i].MusteriId + "-)");
                Console.WriteLine("Müşteri Adı : " + musteri[i].MusteriAd);
                Console.WriteLine("Müşteri Soyadı: " + musteri[i].MusteriSoyad);
            }

            
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
        

            musteriManager.Sil(musteri2);
         

            Musteri[] musteriList = new Musteri[] { musteri1, musteri2 };
            musteriManager.Listele(musteriList);
        }
    }
}
