using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 具体服饰类(concreateDecorator)
    /// </summary>
    public class TShirts:Finery
    {
        public override void Show()
        {
            Console.Write("大T恤");
            base.Show();
        }
    }
}
