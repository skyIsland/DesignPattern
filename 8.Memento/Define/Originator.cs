using System;
using System.Collections.Generic;
using System.Text;

namespace _8.Memento.Define
{
    /// <summary>
    /// 发起人类 依赖于备忘录类
    /// </summary>
    class Originator
    {
        public string State { get; set; }

        /// <summary>
        /// 创建备忘录，将当前需要保存的信息导入并实例化出一个Memento对象
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        /// <summary>
        /// 恢复备忘录类
        /// </summary>
        /// <param name="memento"></param>
        public void SetMemento(Memento memento)
        {
            this.State = memento.State;
        }

        /// <summary>
        /// 显示数据
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"State{State}");
        }
    }
}
