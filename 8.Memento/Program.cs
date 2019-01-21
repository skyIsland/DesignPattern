using System;
using _8.Memento.Define;

namespace _8.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void Test()
        {
            // 实例化发起人类
            Originator o = new Originator();

            // 发起人状态为开启
            o.State = "On";
            o.Show();

            // 实例化管理者类
            Caretaker c = new Caretaker();

            // 管理者开始管理备忘录 （内部关联备忘录）备份备忘录 
            c.Memento = o.CreateMemento();

            // 发起人状态改变
            o.State = "Off";
            o.Show();

            // 发起人恢复备忘录
            o.SetMemento(c.Memento);
            o.Show();
        }
    }
}
