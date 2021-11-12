using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class SpringTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("显示浅绿色文本框...");
        }
    }
}
