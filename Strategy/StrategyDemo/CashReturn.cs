using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.StrategyDemo
{
    /// <summary>
    /// 返利收费子类-具体算法策略
    /// </summary>
    class CashReturn:CashSuper
    {
        /// <summary>
        /// 返利条件
        /// </summary>
        private double moneyCondition = 0.0d;

        /// <summary>
        /// 返利金额
        /// </summary>
        private double returnMoney = 0.0d;

        public CashReturn(double moneyCondition, double returnMoney)
        {
            this.moneyCondition = moneyCondition;
            this.returnMoney = returnMoney;
        }
        public override double GetResult(double money)
        {
            double result = money;

            if (money >= moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * returnMoney;
            }

            return result;
        }
    }
}
