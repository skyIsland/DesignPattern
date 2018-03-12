using Decorator;
using MessageHandler;
using MessageHandler.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2();
            Console.ReadKey();
        }
        
        static void Test1()
        {
            var person = new Person("张三");

            // 装饰模式
            /*
             * Component: 定义好的对象接口 可以给这个对象动态地添加职责 -- Person类
             * ConcreateComponent: 定义了一个具体的对象 也可以给这个对象添加一些职责 --这里没用到
             * Decorator: 装饰抽象类 继承了Component 从外类来扩展Component类的功能 -- Finery类 
             * ConcreateDecoratorA: 具体的装饰对象 继承了Decorator类 起到给Component添加职责的功能 --TShirts
             * ConcreateDecoratorB
             */

            // 实例化具体的服饰对象
            var tsh = new TShirts();
            var bigTh = new BigTrouser();

            // 开始装饰
            tsh.Decorate(person);
            bigTh.Decorate(tsh);

            // show
            bigTh.Show();
        }

        static void Test2()
        {
            // 默认装饰
            MessageComponent defaultMessage = new DefaultMessage();

            // email装饰添加职责
            var emailDecorator = new EmailDecorator(defaultMessage);

            // SMS装饰添加职责
            var smsDecorator = new SMSDecorator(emailDecorator);//把emailDecorator添加到sms后，同时它集成了defaultMessage
            smsDecorator.Send("测试发送...");
        }
    }
}
