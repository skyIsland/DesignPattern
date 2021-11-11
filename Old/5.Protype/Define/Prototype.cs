using System;
using System.Collections.Generic;
using System.Text;

namespace _5.Protype.Define
{
    public abstract class Prototype
    {
        public string Id { get; set; }

        protected Prototype(string id)
        {
            this.Id = id;
        }

        public abstract Prototype Clone();
    }
}
