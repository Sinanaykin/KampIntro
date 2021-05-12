using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
                {
                    "asdadasdasd","sadasdasdasdasdasd","asdasdasdasdasd","asdasdas","213123123"
                };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
