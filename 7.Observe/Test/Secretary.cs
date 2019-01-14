using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Observe.Test
{
    /// <summary>
    /// 秘书类
    /// </summary>
    class Secretary : ISubject
    {
        public Action Update;

        public string SubjectState { get; set; }

        public void Notify()
        {
            Update();
        }
    }
}
