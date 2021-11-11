using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Proxy.ProxyDefine
{
    /// <summary>
    /// 定义了代理（proxy）代表的真实实体
    /// </summary>
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实的请求.");
        }
    }
}
