using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 目标抽象类-成绩接口
    /// </summary>
    public interface IScoreOperation
    {
        int[] Sort(int[] array);

        int Search(int[] array, int key);
    }
}
