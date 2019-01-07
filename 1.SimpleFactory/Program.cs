using System;
using static _1.SimpleFactory.OperationFactory;

namespace _1.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建工厂实例
            Operation oper;
            oper = CreateOperation(Operate.Add);
            oper.NumberA = 5;
            oper.NumberB = 5;
            double result = oper.GetResult();
            Console.WriteLine(result);

            oper = CreateOperation(Operate.Sub);
            oper.NumberA = 5;
            oper.NumberB = 5;
            result = oper.GetResult();
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
