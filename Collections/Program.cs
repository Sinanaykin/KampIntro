﻿using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string[] isimler = new string[]
        //    {
        //        "Engin","Murat","Kerem"
        //    };
        //    Console.WriteLine(isimler[0]);
        //    Console.WriteLine(isimler[1]);
        //    Console.WriteLine(isimler[2]);

          List<string> isimler2 = new List<string> { "ali", "ayse", "veli" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("İLKER");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
