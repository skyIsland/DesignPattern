﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class SummerTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("显示浅蓝色文本框...");
        }
    }
}
