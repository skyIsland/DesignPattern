﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 适配器
    /// </summary>
    public class OperationAdapter : IScoreOperation
    {
        private QuickSortHelper sortTarget;
        private BinarySearchHelper searchTarget;

        public OperationAdapter()
        {
            sortTarget = new QuickSortHelper();
            searchTarget = new BinarySearchHelper();
        }

        public int Search(int[] array, int key)
        {
            return searchTarget.BinarySearch(array, key);
        }

        public int[] Sort(int[] array)
        {
            return sortTarget.QuickSort(array);
        }
    }
}
