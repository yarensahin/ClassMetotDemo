using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(params Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine($"Id: {musteri.Id} Ad: {musteri.Ad} Soyad: {musteri.Soyad} Yaş:{musteri.Yas}," +
                    $" bilgilerine sahip müşteri eklenmiştir.");
            }

        }
        public void MusteriSil(params Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine($"Id: {musteri.Id} Ad: {musteri.Ad} Soyad: {musteri.Soyad} Yaş:{musteri.Yas}," +
                    $" bilgilerine sahip müşteri silinmiştir.");
            }

        }
        public void MusteriListele(params Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {

                Console.WriteLine($"Id: {musteri.Id} Ad: {musteri.Ad} Soyad: {musteri.Soyad} Yaş:{musteri.Yas}");

            }
        }
    }
}
