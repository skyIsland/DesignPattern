using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler
{
    /// <summary>
    /// 消息发送元件
    /// </summary>
    public abstract class MessageComponent
    {
        public abstract void Send(string message);
    }

    /// <summary>
    /// 默认实现消息发送,可以记录日志,订阅事件,实现默认的发送消息等功能
    /// </summary>
    public class DefaultMessage : MessageComponent
    {
        public override void Send(string message)
        {
            Console.WriteLine("默认的消息发送机制");
        }
    }
}
