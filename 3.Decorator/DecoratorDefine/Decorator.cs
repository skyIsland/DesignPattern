using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Decorator.DecoratorDefine
{
    /// <summary>
    /// 装饰抽象类 内部关联Component
    /// </summary>
    public abstract class Decorator : Component
    {
        protected Component component;


        /// <summary>
        /// 设置关联的实例Component
        /// </summary>
        /// <param name="component"></param>
        public void SetComponent(Component component)
        {
            this.component = component;
        }

        /// <summary>
        /// 重写Operation 实际是调用关联的Component的Operation
        /// </summary>
        public override void Operation()
        {
            component?.Operation();
        }
    }
}
