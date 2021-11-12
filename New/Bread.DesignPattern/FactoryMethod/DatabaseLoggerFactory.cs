using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 具体产品
    /// </summary>
    public class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            ILogger logger = new DatabaseLogger();

            // 具体的代码细节...

            return logger;
        }
    }
}
