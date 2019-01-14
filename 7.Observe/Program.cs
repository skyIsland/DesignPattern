using System;
using _7.Observe.Define;

namespace _7.Observe
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
