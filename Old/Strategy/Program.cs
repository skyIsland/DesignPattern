using System;
using Strategy.StrategyDefine;
using Strategy.StrategyDemo;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 策略模式：定义了算法家族，分别封装起来，
             * 让它们之间可以互相替换，此模式让算法的变化，不会影响到使用算法的客户
             */
           
            Test1();

            Test2();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void Test2()
        {
            double money = 33333.1;
            CashContext cc;

            // 可以改造一下上下文类 加入简单工厂 让客户端脱离具体算法类

            // 构造实例化算法A策略 正常收费
            cc = new CashContext(new CashNormal());
            Console.WriteLine(cc.GetLasResult(money));
           
            // 构造实例化算法B策略 打折
            cc = new CashContext(new CashRebate(0.8));
            Console.WriteLine(cc.GetLasResult(money));

            // 构造实例化算法C策略 返利
            cc = new CashContext(new CashReturn(0.8, 500));
            Console.WriteLine(cc.GetLasResult(money));

        }

        private static void Test1()
        {
            Context ct;

            // 构造实例化算法A策略
            ct = new Context(new StrategyA());
            ct.ContextInterface();

            // 构造实例化算法B策略
            ct = new Context(new StrategyB());
            ct.ContextInterface();
        }
    }
}
