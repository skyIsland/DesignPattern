using System;

namespace SimpleFactory
{
    /*
     * 画图的实例
     * 需要画什么图就创建什么图的工厂，调用工厂的具体方法，但是如果后续要增加新的工厂和新的实现方法
     * 就要修改原有的代码，增加else 不符合开放封闭的原则
     */
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
