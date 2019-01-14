using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Observe.Test
{
    /// <summary>
    /// 具体观察者 看股票的同事
    /// </summary>
    class StockObserver
    {
        private string name;
        private ISubject subject;
        public StockObserver(string name, ISubject sub)
        {
            this.name = name;
            this.subject = sub;
        }

        /// <summary>
        /// 关闭股票行情
        /// </summary>
        public void CloseStockMarket()
        {
            Console.WriteLine($"{subject.SubjectState}{name} 关闭股票行情，继续工作！");
        }
    }
}
