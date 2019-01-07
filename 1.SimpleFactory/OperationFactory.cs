using System;
using System.Collections.Generic;
using System.Text;

namespace _1.SimpleFactory
{
    public class OperationFactory
    {
        public enum Operate
        {
            Add,
            Sub,
            Mul,
            Div
        }
        public static Operation CreateOperation(Operate operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case Operate.Add:
                    oper = new OperationAdd();
                    break;
                case Operate.Sub:
                    oper = new OperationSub();
                    break;
                case Operate.Mul:
                    oper = new OperationMul();
                    break;
                case Operate.Div:
                    oper = new OperationDiv();
                    break;
                default:
                    break;
            }
            return oper;
        }
    }
}
