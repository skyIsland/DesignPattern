using System;
using System.Collections.Generic;
using System.Text;

namespace ObServerDefined
{
    /// <summary>
    /// 具体观察者
    /// </summary>
    public class ConcreteObserver:Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this._name = name;
            this._subject = subject;
        }
        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine($"观察者{_name}的新状态是{_observerState}.");
        }
    }
}
