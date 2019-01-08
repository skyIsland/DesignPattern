using System;
using _3.Decorator.DecoratorDefine;

namespace _3.Decorator
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
            // 首先实例化具体对象ConcreateComponent 【具体组合】
            ConcreateComponent c = new ConcreateComponent();

            // 然后实例化具体装饰类
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // 开始包装
            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();
        }
    }
}
