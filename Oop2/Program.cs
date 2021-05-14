using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
;            musteri1.MusteriNo = "12345";
            musteri1.Adi = "SİNAN";
            musteri1.Soyadi = "AYKIN";
            musteri1.TcNo = "12345678986";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "45628";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "123465987";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

        }
    }
}
