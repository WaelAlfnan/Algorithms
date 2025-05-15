namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 9, 8, 7, 4, 1, 0, 56, -5 };
            
            BubbleSort(arr);

            string SortedArray = string.Join(",", arr);

            Console.WriteLine(SortedArray);
        }

        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);

                }
            }
        }
    }
}
