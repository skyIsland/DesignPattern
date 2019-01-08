using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Decorator.DecoratorDefine
{
    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            OtherOperation();
            Console.WriteLine("具体装饰B类的操作。");
        }

        public void OtherOperation()
        {

        }
    }
}
