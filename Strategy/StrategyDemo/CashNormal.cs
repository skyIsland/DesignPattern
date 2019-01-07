using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.StrategyDemo
{
    /// <summary>
    /// 正常收费子类-具体算法策略
    /// </summary>
    public class CashNormal:CashSuper
    {
        public override double GetResult(double money)
        {
            return money;
        }
    }
}
