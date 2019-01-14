using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Observe.Define
{
    /// <summary>
    /// 具体观察者 关联具体主题对象
    /// </summary>
    class ConcreteObserve : Observe
    {
        private string _name;

        private string _observerState;

        public ConcreateSubject Subject { get; set; }

        public ConcreteObserve(ConcreateSubject subject, string name)
        {
            this.Subject = subject;
            this._name = name;
        }

        public override void Update()
        {
            _observerState = Subject.SubjectState;
            Console.WriteLine($"具体观察者{_name}收到指令，更改状态为{_observerState}");
        }
    }
}
