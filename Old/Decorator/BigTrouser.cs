using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 具体服饰类
    /// </summary>
    public class BigTrouser:Finery
    {
        public override void Show()
        {
            Console.Write("垮裤");
            base.Show();
        }
    }
}
