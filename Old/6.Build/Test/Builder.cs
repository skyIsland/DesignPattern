using System;
using System.Collections.Generic;
using System.Text;

namespace _6.Build.Test
{
    /// <summary>
    /// 抽象建造者类
    /// </summary>
    abstract class Builder
    {
        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract Product GetResult();


    }
}
