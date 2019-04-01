﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BaseClass
{
    public static class QuickSort
    {
        public static void QuickSortArray(int[] array)
        {
            if (array is null) return;
            QuickSortArray(array, 0, array.Length - 1);
        }

        public static void QuickSortArray(int[] a, int l, int r)
        {
            if (r <= l) return;
            int k;
            var v = a[r];
            int i = l - 1, j = r, p = l - 1, q = r;
            while (true)
            {
                while (a[++i] < v) ;
                while (v < a[--j]) if (j == l) break;
                if (i >= j) break;
                Swap(a, i, j);
                if (a[i] == v) { p++; Swap(a, p, i); }
                if (v == a[j]) { q--; Swap(a, q, j); }
            }
            Swap(a, i, r);
            j = i - 1;
            i = i + 1;
            for (k = l; k <= p; k++, j--)
                Swap(a, k, j);
            for (k = r - 1; k >= q; k--, i++)
                Swap(a, k, i);
            QuickSortArray(a, l, j);
            QuickSortArray(a, i, r);
        }

        public static void Swap(int[] array, int i, int j)
        {
            var e = array[i];
            array[i] = array[j];
            array[j] = e;
        }
    }
}
