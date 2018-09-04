using System;
using System.Collections.Generic;
using System.Text;

namespace ObServerDefined
{
    /// <summary>
    /// 具体目标/通知者，将有关状态存入具体观察者对象
    /// </summary>
    public class ConcreteSubject:Subject
    {
        public string SubjectState { get; set; }
    }
}
