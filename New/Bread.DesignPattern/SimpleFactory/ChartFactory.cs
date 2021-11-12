using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class ChartFactory
    {
        public static IChartable GetChart(string type)
        {
            IChartable chartable = null;

            if (!string.IsNullOrEmpty(type))
            {
                if (type.Equals("histogram", StringComparison.OrdinalIgnoreCase))
                {
                    chartable = new HistogramChart();
                    Console.WriteLine("初始化设置柱状图...");
                }
                else if (type.Equals("pie", StringComparison.OrdinalIgnoreCase))
                {
                    chartable = new PieChart();
                    Console.WriteLine("初始化设置饼状图...");
                }
                else if (type.Equals("line", StringComparison.OrdinalIgnoreCase))
                {
                    chartable = new LineChart();
                    Console.WriteLine("初始化设置折线图...");
                }
            }

            return chartable;
        }
    }
}
