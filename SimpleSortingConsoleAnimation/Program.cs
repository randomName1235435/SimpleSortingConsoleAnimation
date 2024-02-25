class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 3, 8, 4, 2 };

        Console.WriteLine("Original Array:");
        PrintBarChart(array);

        BubbleSort(array);

        Console.WriteLine("\nSorted Array:");
        PrintBarChart(array);
    }
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 1; i < n; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    Swap(arr, i - 1, i);
                    PrintBarChart(arr, i);
                    swapped = true;
                }
            }
        } while (swapped);
    }

    private static void Swap(int[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }

    static void PrintBarChart(int[] arr, int highlightIndex = -1)
    {
        Console.Clear();
        int max = arr.Max();
        foreach (var item in arr)
        {
            int barLength = Convert.ToInt32(20 * (double)item / max);
            ConsoleColor nextBackgroundColor;
            if (highlightIndex != -1 && item == arr[highlightIndex])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                nextBackgroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ResetColor();
                nextBackgroundColor = ConsoleColor.Gray;
            }

            Console.Write($"{item,3} |");
            Console.BackgroundColor = nextBackgroundColor;
            Console.Write(new string(' ', barLength));
            Console.ResetColor();
            Console.WriteLine();
        }
        Thread.Sleep(500);
    }
}