using DocumentFormat.OpenXml.ExtendedProperties;
using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> Words = new MyDictionary<string>();
            Words.Add("Word");
            Console.WriteLine(Words.Length);

            Words.Add("Class");
            Console.WriteLine(Words.Length);

            Words.Add("Anything");
            Console.WriteLine(Words.Length);


            foreach (var word in Words.Items)
            {
                Console.WriteLine(word);
            }


        }
    }
}
