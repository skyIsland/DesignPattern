using System;

namespace SimpleFactory
{
    class Program
    {
        /*
         * 简单工厂
         * 一个工厂 依赖抽象产品
         * 抽象产品
         * 具体产品 实现抽象产品
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IChartable chart = ChartFactory.GetChart("histogram");
            if (chart != null)
            {
                chart.Display();
            }

            Console.WriteLine();

            chart = ChartFactory.GetChart("pie");
            if (chart != null)
            {
                chart.Display();
            }

            Console.ReadKey();
        }
    }
}
