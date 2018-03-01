using System;
using System.Collections.Generic;
using System.Text;

namespace OperationLayer
{
    public class OperationFactory
    {
        /// <summary>
        /// 运算类工厂
        /// </summary>
        /// <param name="opStr"></param>
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
