using System;
using System.Collections.Generic;
using System.Text;

namespace _6.Build.Test
{
    /// <summary>
    /// 具体建造者类 关联产品类（具体产品）
    /// </summary>
    class ConcreateBuilder2 : Builder
    {
        private readonly Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("部件x");
        }

        public override void BuildPartB()
        {
            product.Add("部件y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
