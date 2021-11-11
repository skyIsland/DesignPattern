using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Decorators
{
    /// <summary>
    /// Email消息发送装饰器
    /// </summary>
    public class EmailDecorator : MessageDecorator
    {
        public EmailDecorator() : this(null)
        {
        }

        public EmailDecorator(MessageComponent messageContaion) : base(messageContaion)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("采用Email发送消息...");
        }

    }
}
