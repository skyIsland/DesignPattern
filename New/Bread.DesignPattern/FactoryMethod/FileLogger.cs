using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("这里是文件记录日志...");
        }
    }
}
