using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Observe.Define
{
    /// <summary>
    /// 主题/抽象通知者 关联抽象观察者
    /// </summary>
    abstract class Subject
    {
        private IList<Observe> observes =  new List<Observe>();

        /// <summary>
        /// 增加观察者
        /// </summary>
        /// <param name="observe"></param>
        public void Attach(Observe observe)
        {
            observes.Add(observe);
        }

        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observe"></param>
        public void Detach(Observe observe)
        {
            observes.Remove(observe);
        }

        /// <summary>
        /// 通知
        /// </summary>
        public void Notify()
        {
            foreach (var observe in observes)
            {
               observe.Update();
            }
        }
    }
}
