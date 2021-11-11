using System;

namespace _4.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void Test1()
        {
            // 声明代理
            _4.Proxy.ProxyDefine.Proxy proxy = new _4.Proxy.ProxyDefine.Proxy();

            // 调用
            proxy.Request();
        }
    }
}
