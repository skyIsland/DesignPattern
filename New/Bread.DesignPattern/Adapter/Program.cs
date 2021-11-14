using System;

namespace Adapter
{
    /*
     * 适配器（Adapter）模式：将一个接口转换成客户希望的另一个接口，使接口不兼容的那些类可以一起工作。
     * 目标抽象类
     * 适配器类
     * 适配者类
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IScoreOperation operation = new OperationAdapter();
            if (operation == null)
            {
                return;
            }

            int[] scores = { 84, 76, 50, 69, 90, 91, 88, 96 };
            int[] result;
            int score;

            Console.WriteLine("测试成绩排序结果：");
            result = operation.Sort(scores);
            foreach (int s in result)
            {
                Console.Write("{0},", s.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("查找是否有90分的人：");
            score = operation.Search(scores, 90);
            if (score == -1)
            {
                Console.WriteLine("抱歉，这个真没找到~~~");
            }
            else
            {
                Console.WriteLine("恭喜，的确存在90分选手~~~");
            }

            Console.WriteLine("查找是否有92分的人：");
            score = operation.Search(scores, 92);
            if (score == -1)
            {
                Console.WriteLine("抱歉，这个真没找到~~~");
            }
            else
            {
                Console.WriteLine("恭喜，的确存在92分选手~~~");
            }

            Console.ReadKey();
        }
    }
}
