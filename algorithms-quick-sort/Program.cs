using algorithms_quick_sort.Sort;
using algotihms_quick_sort.ArrayExtensions;

namespace algorithms_quick_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 7, 8, 1, 2, 90, 4, 65, 32 };
            QuickSort.Execute(values);
            values.PrintValues();
        }
    }
}
