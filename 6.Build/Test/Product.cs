using System;
using System.Collections.Generic;
using System.Text;

namespace _6.Build.Test
{
    class Product
    {
        readonly IList<string> parts = new List<string>();

        /// <summary>
        /// 添加产品部件
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n产品创建");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
