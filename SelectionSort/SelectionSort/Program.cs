namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 1, 6, 0, -5, 14, 3 };
            selectionSort(arr, arr.Length);
            
            string listOfNumbers = string.Join(",", arr);

            Console.WriteLine(listOfNumbers);
        }

        public static void selectionSort(int[] arr, int size)
        {
            int min = 0, temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if( arr[j] < arr[min])
                        min = j;
                }
                if( min != i)
                    // Swapping using Tuple Deconstruction in modern C# (C# 7.0+)
                    //(arr[i], arr[min]) = (arr[min], arr[i]);

                    // Swapping using a Generic Swap Method
                    Swap(ref arr[i], ref arr[min]);
            }
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
