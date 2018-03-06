using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCash
{
    /// <summary>
    /// 打折收费
    /// </summary>
    class CashRebate : CashSuper
    {
        /// <summary>
        /// 折扣率
        /// </summary>
        private double MoneyRebate { get; set; } = 1d;

        /// <summary>
        /// 初始化折扣率
        /// </summary>
        /// <param name="moneyRebate"></param>
        public CashRebate(double moneyRebate)
        {
            this.MoneyRebate = moneyRebate;
        }

        /// <summary>
        /// 打折收费
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            return money * this.MoneyRebate;
        }
    }
}
