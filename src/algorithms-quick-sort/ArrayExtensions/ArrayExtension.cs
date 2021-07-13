using System;
using System.Linq;

namespace algotihms_quick_sort.ArrayExtensions

{
    public static class ArrayExtension
    {
        public static void PrintValues(this int[] array)
        {
            array.ToList().ForEach(v => Console.Write($"{v} "));
        }
    }
}