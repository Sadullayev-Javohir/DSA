class Program
{
    static void Main()
    {
        int[] arr = { 4, 2, 3, 10, 0 };
        SugarCocktail(arr);

        foreach (var i in arr)
        {
            Console.Write(i + " ");
        }
        
    }
    
    // Early Exit Bubble Sort 
    
    static void EarlyExitBubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j],  arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
    
    // Bubble Sort Last Swap
    static void BubbleSortLastSwap(int[] arr)
    {
        int n = arr.Length;

        while (n > 0)
        {
            int lastSwap = 0;
            for (int j = 0; j < n - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    lastSwap = j + 1;
                } 
            }
            n = lastSwap;

            if (n == 0) break;

        }
    }
    
    // Cocktail Sugar Bubble Sort

    static void SugarCocktail(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        bool swapped =  true;

        while (swapped)
        {
            swapped = false;

            for (int i = left; i < right; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    swapped = true;
                }
            }

            right--;
            
            if (!swapped) break;
            
            swapped = false;

            for (int i = right; i > left; i--)
            {
                if (arr[i] < arr[i - 1])
                {
                    (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                    swapped = true;
                }
            }

            left++;
        }
    }
}