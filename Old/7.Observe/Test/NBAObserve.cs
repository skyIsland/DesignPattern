using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Observe.Test
{
    /// <summary>
    /// 具体观察者 看NBA的同事
    /// </summary>
    class NBAObserve
    {
        private string name;
        private ISubject subject;
        public NBAObserve(string name, ISubject sub)
        {
            this.name = name;
            this.subject = sub;
        }

        /// <summary>
        /// 关闭NBA直播
        /// </summary>
        public void CloseNBADirectSeeding()
        {
            Console.WriteLine($"{subject.SubjectState}{name} 关闭NBA直播，继续工作！");
        }
    }
}
