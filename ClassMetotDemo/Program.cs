using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Id = 1234,
                Ad = "Murat",
                Soyad = "Yılmaz",
                Yas = 35
            };

            Musteri musteri2 = new Musteri
            {
                Id = 6789,
                Ad = "Kübra",
                Soyad = "Coşkun",
                Yas = 28
            };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("-----------------Müşteri Listesi-------------");
            musteriManager.MusteriListele(musteri1, musteri2);

            Console.WriteLine("\n-----------------Müşteri Ekleme--------------");
            musteriManager.MusteriEkle(musteri1, musteri2);

            Console.WriteLine("\n-----------------Müşteri Silme--------------");
            musteriManager.MusteriSil(musteri1, musteri2);
        }
    }
}
