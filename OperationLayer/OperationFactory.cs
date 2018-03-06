using System;
using System.Collections.Generic;
using System.Text;

namespace OperationLayer
{
    /// <summary>
    /// 运算类工厂
    /// </summary>
    public class OperationFactory
    {
       /// <summary>
       /// 根据操作符生成相应的运算类
       /// </summary>
       /// <param name="opStr">操作符</param>
       /// <returns></returns>
        public static Operation CreateOpertion(string opStr)
        {
            Operation op = null;
            switch (opStr)
            {
                case "+":
                    op = new MostOperation.OperationAdd();
                    break;
                case "/":
                    op = new MostOperation.OperationDiv();
                    break;
            }
            return op;
        }
    }
}
