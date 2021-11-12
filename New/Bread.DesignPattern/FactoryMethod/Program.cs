using System;

namespace FactoryMethod
{
    /*
     * 一个日记记录的实例
     * 符合开闭原则，用户只需要关心所需产品对应的工厂无需关心创建细节
     * 增加新的产品，系统中类的个数将成对增加，一定程度上增加了系统复杂度
     */
    class Program
    {
        /*
         * 定义一个用于创建对象的接口，让子类决定将哪一个类实例化。工厂方法模式让一个类的实例化延迟到其子类。工厂方法模式又简称为工厂模式，也可称为多态工厂模式，它是一种创建型模式。　
         * 抽象工厂
         * 具体工厂 依赖具体产品 继承抽象工厂
         * 抽象产品
         * 具体产品 实现抽象产品
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 可通过引入配置文件实现具体要哪个工厂
            ILoggerFactory factory = new FileLoggerFactory(); 
            if (factory == null)
            {
                return;
            }

            // 如果后续要增加第三种日志记录，则只需要增加第三个具体工厂（依赖于抽象工厂）第三个具体产品（实现抽象产品）符合开闭原则
            ILogger logger = factory.CreateLogger();// 可以隐藏具体产品
            logger.WriteLog();
            
            Console.ReadKey();
        }
    }
}
