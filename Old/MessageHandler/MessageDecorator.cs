using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler
{
    /// <summary>
    /// 对消息发送的装饰(控制),如加个Email发送,SMS发送等 具体是怎么装饰由传进来的MessageComponent决定
    /// </summary>
    public class MessageDecorator : MessageComponent
    {

        private MessageComponent _messageContaion;

        public MessageDecorator(MessageComponent messageComponent)
        {
            this._messageContaion = messageComponent;
        }

        public override void Send(string message)
        {
            // 判断一下是否已经传进来具体的装饰模式
            _messageContaion?.Send(message);
        }
    }
}
