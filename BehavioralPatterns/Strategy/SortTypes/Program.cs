namespace SortTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortStrategy<int> quickSort = new QuickSort<int>();
            SortedList<int> numbers = new SortedList<int>();
            numbers.Sort(quickSort);

            SortStrategy<string> mergeSort = new MergeSort<string>();
            SortedList<string> names = new SortedList<string>();
            names.Sort(mergeSort);
        }
    }
}
