using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();

               
                urun1.Adi = "telefon";
                urun1.Aciklama = "dasdasfssaffs";
                urun1.Fiyati = 122.5;

            Urun urun2 = new Urun();

            urun2.Adi = "telefon55";
            urun2.Aciklama = "dasdsadasfssaffs";
            urun2.Fiyati = 182.5;

            Urun[] urunler = new Urun[] { urun1, urun2 };
            
                
                foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            }

            Console.WriteLine("------------------------------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle2(urun2);

                
        
        }
    }
}
