using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.StrategyDefine
{
    /// <summary>
    /// 上下文 
    /// </summary>
    public class Context
    {
        private readonly Strategy strategy;

        /// <summary>
        /// 构造函数接收具体的策略对象
        /// </summary>
        /// <param name="strategy"></param>
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        /// <summary>
        /// 上下文接口 调用具体的策略对象的结果
        /// </summary>
        public void ContextInterface()
        {
            this.strategy.AlgorithmInterface();
        }
    }
}
