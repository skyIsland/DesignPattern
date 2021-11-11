using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Proxy.ProxyDefine
{
    /// <summary>
    /// 代理,内部关联真实实体
    /// </summary>
    public class Proxy : Subject
    {
        private RealSubject realSubject;
        public override void Request()
        {
            if(realSubject == null)
            {
                realSubject = new RealSubject();
            }

            Console.WriteLine("进入代理...");

            // 实际上是执行关联的真实实体的方法
            realSubject.Request();
        }
    }
}
