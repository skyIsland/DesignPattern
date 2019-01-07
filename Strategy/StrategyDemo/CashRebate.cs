using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.StrategyDemo
{
    /// <summary>
    /// 打折收费子类-具体算法策略
    /// </summary>
    class CashRebate:CashSuper
    {
        private double moneyRebate;
        /// <summary>
        /// 构造函数传入折扣率
        /// </summary>
        /// <param name="moneyRebate"></param>
        public CashRebate(double moneyRebate)
        {
            this.moneyRebate = moneyRebate;
        }

        public override double GetResult(double money)
        {
            return money * moneyRebate;
        }
    }
}
