using System;
using System.Collections.Generic;
using System.Text;

namespace _9.Composite.Define
{
    abstract class Component
    {
        protected string Name;

        public Component(string name)
        {
            this.Name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}
