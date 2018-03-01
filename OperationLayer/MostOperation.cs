using System;
using System.Collections.Generic;
using System.Text;

namespace OperationLayer
{
   
    public class MostOperation
    {
        /// <summary>
        /// 加法类
        /// </summary>
        public class OperationAdd:Operation
        {
            public override double GetResult()
            {
                return NumberA + NumberB;
            }
        }
        /// <summary>
        /// 除法类
        /// </summary>
        public class OperationDiv : Operation
        {
            public override double GetResult()
            {
                if (NumberB == 0)
                {
                    throw new DivideByZeroException("除数不能为0");
                }
                return NumberA / NumberB;
            }
        }
    }
}
