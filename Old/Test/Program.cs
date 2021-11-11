using System;
using OperationLayer;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "计算器";
            try
            {
                double numberA = 0;
                double numberB = 0;
                var opStr = string.Empty;
                Operation op = null;
                double result = 0;

                Console.Write("请输入第一个操作数:");
                numberA = double.Parse(Console.ReadLine());
                Console.Write("请输入第二个操作数:");
                numberB = double.Parse(Console.ReadLine());

                Console.Write("请输入运算符(+,/):");
                opStr = Console.ReadLine();

                op = OperationFactory.CreateOpertion(opStr);
                op.NumberA = numberA;
                op.NumberB = numberB;
                result = op.GetResult();

                Console.WriteLine("\n");
                Console.WriteLine("******************");
                Console.WriteLine("运算结果为:"+ result);
                Console.WriteLine("******************");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"发生错误,原因:{ex.Message}");
            }            
            Console.ReadKey();
        }
    }
}
