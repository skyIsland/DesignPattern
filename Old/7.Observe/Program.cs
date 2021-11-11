using System;
using _7.Observe.Define;
using _7.Observe.Test;

namespace _7.Observe
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();

            Console.WriteLine();

            Test2();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void Test2()
        {
            // 老板胡汉三
            Boss huHanSan = new Boss();

            // 看股票的同事
            StockObserver stockFriend = new StockObserver("张三", huHanSan);

            // 看NBA的同事
            NBAObserve nbaFriend = new NBAObserve("李四", huHanSan);

            // 挂载方法
            huHanSan.Update+= stockFriend.CloseStockMarket;
            huHanSan.Update+= nbaFriend.CloseNBADirectSeeding;

            // 老板回来
            huHanSan.SubjectState = "我胡汉三回来了！";

            // 发出通知
            huHanSan.Notify();
        }

        private static void Test1()
        {
            // 实例化具体对象主题(监控者~~)
            ConcreateSubject subject = new ConcreateSubject();

            // 增加观察者 让主题对象关联到观察者
            subject.Attach(new ConcreteObserve(subject, "x"));
            subject.Attach(new ConcreteObserve(subject, "y"));
            subject.Attach(new ConcreteObserve(subject, "z"));

            subject.SubjectState = "发出通知。";
            subject.Notify();
        }
    }
}
