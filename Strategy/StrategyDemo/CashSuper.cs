using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.StrategyDemo
{
    /// <summary>
    /// 现金收费抽象类-抽象算法类
    /// </summary>
    public abstract class CashSuper
    {
        public abstract double GetResult(double money);
    }
}
