using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Person类(ConcreteComponent)
    /// </summary>
    public class Person
    {
        public Person() { }

        private string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"装扮的{this.Name}");
        }

    }
}
