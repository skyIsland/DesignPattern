using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverReal
{
    /// <summary>
    /// 具体目标（女神）
    /// </summary>
    public class BeautifulGirl:ISubject
    {
        /// <summary>
        /// 备胎集合
        /// </summary>
        private readonly IList<Observer> _observers = new List<Observer>();
        /// <summary>
        /// 女神状态
        /// </summary>
        public string SubjectState { get; set; }

        /// <summary>
        /// 增加一个备胎
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(Observer observer) => _observers.Add(observer);

        /// <summary>
        /// 减少一个备胎
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(Observer observer) => _observers.Remove(observer);

        /// <summary>
        /// 通知备胎的操作
        /// </summary>
        public void Notify()
        {
            foreach (Observer o in _observers) o.Update();
        }
    }
}
