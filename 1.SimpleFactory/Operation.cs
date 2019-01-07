using System;
using System.Collections.Generic;
using System.Text;

namespace _1.SimpleFactory
{

    /// <summary>
    /// 数学运算类
    /// </summary>
    public class Operation
    {
        public double NumberA { get; set; } = 0;
        public double NumberB { get; set; } = 0;
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    /// <summary>
    /// 加法运算
    /// </summary>
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }


    /// <summary>
    /// 减法运算
    /// </summary>
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    /// <summary>
    /// 乘法运算
    /// </summary>
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    /// <summary>
    /// 除法运算
    /// </summary>
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if(NumberB == 0)
            {
                throw new DivideByZeroException();
            }
            result = NumberA / NumberB;
            return result;
        }
    }
}
