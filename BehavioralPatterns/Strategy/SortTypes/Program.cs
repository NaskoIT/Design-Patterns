namespace SortTypes
{
    using SortTypes.Models;

    public class Program
    {
        public static void Main()
        {
            SortStrategy<int> quickSort = new QuickSort<int>();
            SortedList<int> numbers = new();
            numbers.Sort(quickSort);

            SortStrategy<string> mergeSort = new MergeSort<string>();
            SortedList<string> names = new();
            names.Sort(mergeSort);
        }
    }
}
