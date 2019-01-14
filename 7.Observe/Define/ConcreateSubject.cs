using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Observe.Define
{
    /// <summary>
    /// 具体主题/具体通知者
    /// </summary>
    class ConcreateSubject : Subject
    {
        /// <summary>
        /// 具体被观察者的状态
        /// </summary>
        public string SubjectState { get; set; }
    }
}
