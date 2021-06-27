
namespace algorithms_quick_sort.Sort
{
    public class QuickSort
    {
        public static void Execute(int[] values)
        {
            Sort(values, 0, values.Length - 1);
        }

        private static void Sort(int[] values, int left, int right)
        {
            if (left < right)
            {
                int indexPivot = Partition(values, left, right);
                Sort(values, left, indexPivot - 1);
                Sort(values, indexPivot + 1, right);
            }
        }

        //Lomuto Partition
        private static int Partition(int[] values, int left, int right)
        {
            int pivot = values[left];
            int i = left;

            for (int j = left + 1; j <= right; j++)
            {
                if (values[j] <= pivot)
                {
                    i++;
                    Swap(values, i, j);
                }
            }

            Swap(values, left, i);

            return i;
        }

        private static void Swap(int[] values, int left, int right)
        {
            int value = values[left];
            values[left] = values[right];
            values[right] = value;
        }
    }
}