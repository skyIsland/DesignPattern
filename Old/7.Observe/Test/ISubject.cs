using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Observe.Test
{

    /// <summary>
    /// 通知者接口
    /// </summary>
    interface ISubject
    {
        void Notify();

        string SubjectState { get; set; }
    } 
}
