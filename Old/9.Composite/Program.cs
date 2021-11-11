using _9.Composite.Define;
using System;

namespace _9.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void Test()
        {
            // 生成树根 root 根上长出两叶LeafA和LeafB
            _9.Composite.Define.Composite root = new Define.Composite("root");

            // 根上长出分支compositeX，分支上也有两叶 LeafXA 和LeafXB
            _9.Composite.Define.Composite comp = new Define.Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);

            // 在compositeX再长出分支
            _9.Composite.Define.Composite comp2 = new Define.Composite("Composite XY");
            comp2.Add(new Leaf("Leaf XYA"));
            comp2.Add(new Leaf("Leaf XYB"));

            comp.Add(comp2);

            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);

        }
    }
}
