using System;
using System.Collections.Generic;
using System.Text;

namespace OperationLayer
{
    /// <summary>
    /// 运算类
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// 操作数A
        /// </summary>
        public double NumberA { get; set; }

        /// <summary>
        /// 操作数B
        /// </summary>
        public double NumberB { get; set; }

        /// <summary>
        /// 计算结果
        /// </summary>
        /// <returns></returns>
        public virtual double GetResult()
        {
            return 0;
        }
    }
}
