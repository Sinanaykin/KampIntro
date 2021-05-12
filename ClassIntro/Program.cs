using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "c#";
            kurs1.Egitmen = "sinan aykın";
            kurs1.IzlenmeOrani = 70;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "java";
            kurs2.Egitmen = "sinem aykın";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "python";
            kurs3.Egitmen = "cemal aykın";
            kurs3.IzlenmeOrani = 90;

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3
            };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı+ " " + kurs.Egitmen );
            }
           
        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
 
    }
}
