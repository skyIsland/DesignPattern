using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.StrategyDefine
{
    /// <summary>
    /// 具体算法A
    /// </summary>
    public class StrategyA: Strategy
    {
        /// <summary>
        /// 算法A实现方法
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }
}
