namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = RandomArray.Generate(50);

            int[] sortedArray = BubbleSort.Sort(unsortedArray);

            foreach (int i in sortedArray) { Console.WriteLine(i); }
        }
    }
}