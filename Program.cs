using static System.Console;

namespace SortingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bubbleExample1 = { 34, 12, 56, 78, 23 };
            int[] bubbleExample2 = { 90, 54, 32, 29, 10 };

            DisplayArray(bubbleExample1);
            BubbleSort(bubbleExample1);

            
        }

        /// <summary>
        /// Bubble sort is a simple comparison-based algorithm where adjacent elements are repeatedly swapped if they are in the wrong order.
        /// 
        /// STEPS (for ascending order)
        /// 1. Compare consectuive elements    (34 -- 12) 56 78 23
        /// 2. After comparison, determin if swap is needed    (12 -- 34) 56 78 23
        /// 3. Continue comparing the next set of elements    [12 (34 -- 56) 78 23] ⇒ [12 34 (56 -- 78) 23] ⇒ [12 34 56 (78 -- 23)] ⇒ [12 34 56 23 78]
        /// 4. Repeat steps 1 - 3 until sorted
        /// 
        /// TIME COMPLEXITY
        /// * BEST: O(n)  ;  Worst: O(n^2)  :  Average O(n^2);
        /// 
        /// SPACE COMPLEXITY
        /// * O(1)
        /// 
        /// BEST USE CASES
        /// * Small data sets, simple applications
        /// 
        /// PROS
        /// * Very simple to understand and implement
        /// * Adaptive - can be optimized to stop early if the list is already sorted
        /// 
        /// CONS
        /// * Slow on large data sets
        /// * Ineffiecient for sorting large arrays/lists
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void BubbleSort(int[] arr)
        {
            int temp; //For the swap
            int pass; //To determine how many times to check consecutive elements
            for (pass = arr.Length - 1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr[i], arr[i + 1]);
                    }
                }
            }
            void Swap(int num1, int num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

        }

        /// <summary>
        /// Insertion sort builds the sorted array one item at a time by inserting each element into its proper position
        /// in an already sorted portion of the array
        /// 
        /// STEPS (for ascending order)
        /// 1. Select one element from the left in the collection    (12) (34) 56 78 6
        /// 2. Insert this element in proper location after comparison    (12) (34) 56 78 6 ⇒ minPos = 0
        /// 3. After positions are interchanged, ensure all elements to the left are sorted    [(12) 34 78 56 (6)] ⇒ minPos = 4 ⇒ [6 34 56 23 12]
        /// 4. Repeat steps 1 - 3 until sorted
        /// 
        /// TIME COMPLEXITY
        /// * BEST: O(n)  ;  Worst: O(n^2)  :  Average O(n^2);
        /// 
        /// SPACE COMPLEXITY
        /// * O(1)
        /// 
        /// BEST USE CASES
        /// * Small data sets, simple applications, applications where stability is important
        /// 
        /// PROS
        /// * Very efficient for small or nearly sorted data sets
        /// * Stable - preserves relative order of equal elements
        /// * Adaptive - can be optimized to stop early if the list is already sorted
        /// 
        /// CONS
        /// * Slow on large data sets
        /// * Slower than other algorithms such as Quick Sort or Merge Sort
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void InsertionSort(int[] arr)
        {
            int temp; 
            int position = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i]; //Variable we are trying to insert
                position = i; //Starting position to check

                while (position > 0 && arr[position - 1] > temp)
                {
                    arr[position] = arr[position - 1]; //Will keep going down until the next position is no longer greater than temp (number we are trying to insert)
                    position--;
                }
                arr[position] = temp; //Once we find that spot, insert it.
            }
        }

        static void QuickSort(int[] arr)
        {

        }

        static void ShellSort(int[] arr)
        {

        }

        static void MergeSort(int[] arr)
        {

        }

        #region Display Methods
        static void DisplayArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Write(i + " | ");
            }
            WriteLine();
        }
        static void DisplayArray(int[] arr, int colorNumIndex, int colorNumIndex2)
        {
            foreach (int i in arr)
            {
                if (arr[colorNumIndex] != i && arr[colorNumIndex2] != i + 1)
                    Write(i + " ");
                else
                {
                    if (i == arr[colorNumIndex])
                    {
                        ForegroundColor = ConsoleColor.Green;
                        Write(i + " ");
                        ResetColor();
                    }
                    if (i + 1 == arr[colorNumIndex2])
                    {
                        ForegroundColor = ConsoleColor.Yellow;
                        Write(i + " ");
                        ResetColor();
                    }
                }
            }
            WriteLine();
        }

        #endregion Display Methods

    }
}
