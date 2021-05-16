using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> Names = new MyList<string>();
            Names.Add("Ercan");
            Console.WriteLine(Names.Length);

            Names.Add("Engin");
            Console.WriteLine(Names.Length);

            foreach (var name in Names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}
