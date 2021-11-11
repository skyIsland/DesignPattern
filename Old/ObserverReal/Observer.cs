using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverReal
{
    /// <summary>
    /// 抽象观察者
    /// </summary>
    public abstract class Observer
    {
        public string Name { get; set; }
        public ISubject Sub { get; set; }

        /// <summary>
        /// 通过构造函数注入具体的观察者/目标
        /// </summary>
        /// <param name="name"></param>
        /// <param name="iSub"></param>
        protected Observer(string name, ISubject iSub)
        {
            this.Name = name;
            this.Sub = iSub;
        }
        /// <summary>
        /// 更新
        /// </summary>
        public abstract void Update();
    }
}
