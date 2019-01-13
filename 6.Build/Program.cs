using System;
using _6.Build.Test;

namespace _6.Build
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.WriteLine("Hello World!");
            Console.ReadKey(true);
        }

        private static void Test()
        {
            // 与建造过程分离

            // 实例化指挥者类
            Director director =  new Director();
            
            // 实例化具体建造者类 里氏代换原则
            Builder builder1 = new ConcreateBuilder1();
            Builder builder2 = new ConcreateBuilder2();

            // 使用指挥者类建造产品 传入抽象的建造者类（实际是具体建造者类1）指挥者调用建造者类的建造方法
            director.Construct(builder1);
            Product p1 = builder1.GetResult();
            p1.Show();

            director.Construct(builder2);
            Product p2 = builder2.GetResult();
            p2.Show();
        }
    }
}
