using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Decorators
{
    /// <summary>
    /// SMS消息发送装饰器
    /// </summary>
    public class SMSDecorator : MessageDecorator
    {
        public SMSDecorator() : this(null)
        {
        }

        public SMSDecorator(MessageComponent messageContaion) : base(messageContaion)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("采用SMS发送消息...");
        }

    }
}
