using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.StrategyDemo
{
    /// <summary>
    /// 收银上下文
    /// </summary>
    public class CashContext
    {
        private CashSuper cs;

        public CashContext(CashSuper cs)
        {
            this.cs = cs;
        }

        public double GetLasResult(double money)
        {
            return cs.GetResult(money);
        }
    }
}
