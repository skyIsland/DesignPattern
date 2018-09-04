using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverReal
{
    /// <summary>
    /// 主目标/通知者接口
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// 主目标的状态
        /// </summary>
        string SubjectState { get; set; }
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
    }
}
