using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCash
{
    /// <summary>
    /// 返利收费
    /// </summary>
    class CashReturn : CashSuper
    {
        /// <summary>
        /// 返利条件
        /// </summary>
        private double ReturenCondition { get; set; } = 0.0d;

        /// <summary>
        /// 返利值
        /// </summary>
        private double ReturnMoney { get; set; } = 0.0d;

        /// <summary>
        /// 初始化返利条件和返利值
        /// </summary>
        /// <param name="returnCondition"></param>
        /// <param name="returnMony"></param>
        public CashReturn(double returnCondition, double returnMony)
        {
            this.ReturenCondition = returnCondition;
            this.ReturnMoney = returnMony;
        }

        public override double AcceptCash(double money)
        {
            double result = money;
            if (money >= ReturenCondition)
                result = money - Math.Floor(money / ReturenCondition) * ReturnMoney;
            return result;
        }
    }
}
