using System;
using System.Collections.Generic;
using System.Text;

namespace _8.Memento.Define
{
    /// <summary>
    /// 管理者类
    /// </summary>
    class Caretaker
    {
        /// <summary>
        /// 得到或设置备忘录
        /// </summary>
        public Memento Memento { get; set; }
    }
}
