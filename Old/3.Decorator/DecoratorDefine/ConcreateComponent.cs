using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Decorator.DecoratorDefine
{
    /// <summary>
    /// 定义了具体对象
    /// </summary>
    public class ConcreateComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }
}
