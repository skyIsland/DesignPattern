using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.StrategyDefine
{
    public class StrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }
}
