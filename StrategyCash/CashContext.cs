using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCash
{    
    class CashContext
    {
        private CashSuper Cs = null;

        ///// <summary>
        ///// 初始化具体的收费策略(策略模式)
        ///// </summary>
        ///// <param name="cs"></param>
        //public CashContext(CashSuper cs)
        //{
        //    this.Cs = cs;
        //}

        public CashContext(string csType)
        {
            switch (csType)
            {
                // todo:应该用枚举
                case "正常收费":
                    CashNormal csNormal = new CashNormal();
                    Cs = csNormal;
                    break;
                case "满300返100":
                    CashReturn csReturn = new CashReturn(300, 100);
                    Cs = csReturn;
                    break;
                case "打8折":
                    CashRebate csRebate = new CashRebate(0.8);
                    Cs = csRebate;
                    break;
            }
        }
        /// <summary>
        /// 根据具体的收费策略获得计算结果
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public double GetResult(double money)
        {
            return Cs.AcceptCash(money);
        }
    }
}
