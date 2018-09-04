using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverReal
{
    /// <summary>
    /// 具体的观察者2观察目标(备胎2观察女神)
    /// </summary>
    public class BackupSecond :Observer
    {
        public BackupSecond(string name, ISubject iSub) : base(name, iSub)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"\n{Name}：女神{Sub.SubjectState},我要喜当爹了!");

        }
    }
}
