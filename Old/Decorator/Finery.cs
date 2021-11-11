using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 服饰类 Decorator
    /// </summary>
    public class Finery:Person
    {
        protected Person component;

        /// <summary>
        /// 打扮
        /// </summary>
        /// <param name="component"></param>
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if(this.component != null)
            {
                component.Show();
            }
        }
    }
}
