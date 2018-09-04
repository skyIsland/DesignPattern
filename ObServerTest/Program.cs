using System;
using ObserverReal;
using ObServerDefined;

namespace ObServerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // ObserverDefinedTest();

            ObserverRealTest();
            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        static void ObserverDefinedTest()
        {
            // 具体目标
            ConcreteSubject s = new ConcreteSubject();
            // 添加观察者
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
            // 更改具体目标的状态
            s.SubjectState = "ABC";
            // 通知观察者
            s.Notify();
        }

        static void ObserverRealTest()
        {
            // 实例化一个女神,走起
            BeautifulGirl bg = new BeautifulGirl();

            // 给女神添加两个备胎
            bg.Attach(new BackupFirst("备胎1模式1", bg));
            bg.Attach(new BackupFirst("备胎1模式2", bg));

            bg.Attach(new BackupSecond("备胎2模式1", bg));
            bg.Attach(new BackupSecond("备胎2模式2", bg));

            // 女神怀孕了
            bg.SubjectState = "怀孕了";

            // 通知观察者
            bg.Notify();
        }
    }
}
