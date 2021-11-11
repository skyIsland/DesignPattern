using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Proxy.ProxyDefine
{
    /// <summary>
    /// 代理和实际对象的共用接口
    /// </summary>
    public abstract class Subject
    {
        public abstract void Request();
    }
}
