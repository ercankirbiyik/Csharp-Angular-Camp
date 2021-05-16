using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] Names = new string[] { "Ercan", "Engin", "Kerem", "Hakan" };
            //Console.WriteLine(Names[0]);
            //Console.WriteLine(Names[1]);
            //Console.WriteLine(Names[2]);
            //Console.WriteLine(Names[3]);
            ////arraylerde sabitlik vardır.
            //Names = new string[5]; //5 elemanlı boş bir array oluşturduk.
            //Names[4] = "İlker";
            //Console.WriteLine(Names[4]);
            //Console.WriteLine(Names[0]); // Boş mesaj olarak geri gelecektir, çünkü biz arayimizi yenilediğimizde referans adresini de boşaltıp sadece [4]e bir isim atayıp diğerlerini boş bıraktık.

            List<string> Names2 = new List<string> { "Ercan", "Engin", "Kerem", "Hakan" };

            Console.WriteLine(Names2[0]);
            Console.WriteLine(Names2[1]);
            Console.WriteLine(Names2[2]);
            Console.WriteLine(Names2[3]);
            Names2.Add("İlker");
            Console.WriteLine(Names2[4]);
            Console.WriteLine(Names2[0]);



        }
    }
}
