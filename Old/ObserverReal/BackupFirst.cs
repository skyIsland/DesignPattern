using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverReal
{
    /// <summary>
    /// 具体的观察者1观察目标(备胎1观察女神)
    /// </summary>
    public class BackupFirst :Observer
    {
        public BackupFirst(string name, ISubject iSub) : base(name, iSub)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"\n{Name}：女神{Sub.SubjectState},再也不爱女神了!");
        }
    }
}
