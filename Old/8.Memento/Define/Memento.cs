using System;
using System.Collections.Generic;
using System.Text;

namespace _8.Memento.Define
{
    /// <summary>
    /// 备忘录类
    /// </summary>
    class Memento
    {
        public string State { get; }

        public Memento(string state)
        {
            this.State = state;
        }
    }
}
