using System;
using System.Collections.Generic;
using System.Text;

namespace _6.Build.Test
{
    /// <summary>
    /// 指挥者类
    /// </summary>
    class Director
    {
        /// <summary>
        /// 指挥建造过程
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
