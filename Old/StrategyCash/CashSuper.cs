using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCash
{
    /// <summary>
    /// 现金收费抽象类
    /// </summary>
    abstract class CashSuper
    {
        /// <summary>
        /// 抽象方法
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns>原价</returns>
        public abstract double AcceptCash(double money);
    }
}
