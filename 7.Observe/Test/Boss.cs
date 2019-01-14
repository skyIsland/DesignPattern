
using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Observe.Test
{
    class Boss : ISubject
    {
        public Action Update;

        public string SubjectState { get; set; }


        public void Notify()
        {
            Update();
        }

    }
}
