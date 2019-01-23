using System;
using System.Collections.Generic;
using System.Text;

namespace _9.Composite.Define
{
    class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            // 显示其枝节点名称，并对其下级进行遍历
            Console.WriteLine(new string('-', depth) + Name);

            foreach (var item in children)
            {
                item.Display(depth + 2);
            }
        }
    }
}
