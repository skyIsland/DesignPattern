using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}
