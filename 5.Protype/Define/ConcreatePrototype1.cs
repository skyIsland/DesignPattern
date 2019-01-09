using System;
using System.Collections.Generic;
using System.Text;

namespace _5.Protype.Define
{
    public class ConcreatePrototype1 : Prototype
    {
        public ConcreatePrototype1(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
