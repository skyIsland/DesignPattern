using System;
using ObServerDefined;

namespace ObServerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 具体目标
            ConcreteSubject s = new ConcreteSubject();
            // 添加观察者
            s.Attach(new ConcreteObserver(s,"X"));
            s.Attach(new ConcreteObserver(s,"Y"));
            s.Attach(new ConcreteObserver(s,"Z"));
            // 更改具体目标的状态
            s.SubjectState = "ABC";
            // 通知观察者
            s.Notify();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
