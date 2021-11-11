using System;
using _5.Protype.Define;

namespace _5.Protype
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void Test1()
        {
            ConcreatePrototype1 p1 = new ConcreatePrototype1("1");
            ConcreatePrototype1 p2 = (ConcreatePrototype1) p1.Clone();
            Console.WriteLine($"Cloned{p2.Id}");

        }
    }
}
