using System;
using System.Collections.Generic;
using System.Text;

namespace _9.Composite.Define
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Add(Component c)
        {
            Console.WriteLine("cannot add to a leaf");
        }


        public override void Remove(Component c)
        {
            Console.WriteLine("cannot remove to a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + base.Name);
        }
    }
}
