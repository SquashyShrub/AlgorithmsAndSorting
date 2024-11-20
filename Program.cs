using static System.Console;

namespace SortingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints1 = { 34, 12, 56, 78, 23 };
            int[] ints2 = { 90, 54, 32, 29, 10 };
            int[] ints3 = { 100, 60, 40, 30, 2 };
            int[] ints4 = { 78, 34, 10, 67, 54 };

            
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


        /// <summary>
        /// Selection sort works by repeatedly finding the minimum element from the unsorted portion of the array
        /// and swapping it with the first unsorted element
        /// 
        /// STEPS (for ascending order)
        /// 1. Compare one element with the rest of the array    (12) (34) 56 78 6
        /// 2. IAfter comparison, determine if a new minimum occurs   (12) (34) 56 78 6 ⇒ minPos = 0
        /// 3. Continue comparing the next set of elements    [(12) 34 78 56 (6)] ⇒ minPos = 4 ⇒ [6 12 34 56 23]
        /// 4. Repeat steps 1 - 3 until sorted
        /// 
        /// TIME COMPLEXITY
        /// * BEST: O(n^2)  ;  Worst: O(n^2)  :  Average O(n^2);
        /// 
        /// SPACE COMPLEXITY
        /// * O(1)
        /// 
        /// BEST USE CASES
        /// * Small data sets, simple applications, memory usage is a concern
        /// 
        /// PROS
        /// * Simple and easy to implement
        /// * In-place sorting with O(1) space complexity
        /// * Does not require additional memory
        /// 
        /// CONS
        /// * Slow and inefficient on large data sets
        /// * Not stable - can change the order of equal elements
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void SelectionSort(int[] arr)
        {
            int minPos = 0; //track the position(index) of the minimum element

            for (int i = 0; i < arr.Length - 1; i++)
            {
                minPos = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minPos])
                        minPos = j;
                }
                if (minPos != i)
                {
                    Swap(arr[i], arr[i+1]);
                }
            }
            void Swap(int num1, int num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
        }


        /// <summary>
        /// Quick sort is a divide-and-conquer algorithm that divides the array into subarrays based
        /// on a pivot element, sortin geach subarray recursively
        /// 
        /// STEPS (for ascending order)
        /// 1. Divide and conquer array into sub arrays
        /// 2. Divide the collection into subsets/partitions
        /// 3. Partition is done base on a pivot element
        ///     - Pivot position or element in the pivot spot is a position such that the left side elements are lesser than
        ///     and the right side elements are greater than the pivot
        /// 4. Recursively sor thte subset using the quick sort
        /// 
        /// TIME COMPLEXITY
        /// * BEST: O(n log n)  ;  Worst: O(n^2)  ;  Average O(n log n);
        /// 
        /// SPACE COMPLEXITY
        /// * O(log n) (in place, recursive stack space)
        /// 
        /// BEST USE CASES
        /// * Large data sets, general-purpose sorting, divide-and-conquer apps
        /// 
        /// PROS
        /// * Very fast for large data sets (average O(n log n) time complexity
        /// * In-place sorting uses less memory
        /// * Often faster than merge sort and heap sort in practice, despite have same average time complexity
        /// 
        /// CONS
        /// * Not stable (can change the relative order of equal elements)
        /// * Worst case performance can be a O(n^2) - Good pivot selection helps prevent this
        /// * Recursive implementation leads to stack overhead
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void QuickSort(int[] arr, int low, int high)
        {
            //Get the index
            int partition_index = Partition(arr, low, high);

            //Check the left side of the partition
            QuickSort(arr, low, partition_index - 1);

            //Check the right side of the partition
            QuickSort(arr, partition_index + 1, high);
        }
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low;
            int j = high;

            //Do-While loop establishes the low and high
            do
            {
                //Check the i index has not passed the j index
                //Check the i index is lessed than the pivot number
                while (i <= j && arr[i] <= pivot)
                {
                    i++;
                }
                //If we find a higher value, keep moving left (to find a partition)
                while (i <= j && arr[j] > pivot) ;
                {
                    j--;
                }

                //Both i and j have stopped at this point, so now we check if they need to swap
                if (low <= j) //Checking if i and j have crossed, if not we don't do anything
                {
                    Swap(arr, i, j);
                }
            } while (i < j); //Check if they have crossed here

            if (low != j) //Check if a swap is needed
            {
                Swap(arr, low, j); //Returns the partition 'j' because we have not yet extablished the low number
            }
            return j; //This is the pivot position


            void Swap(int[]arr, int i, int j)
            {
                int temp;
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }


        /// <summary>
        /// Shell sort is an extension of the insertion sort that allows the exchange of items that
        /// are far apart, thus reducing the number of inversions in the array
        /// 
        /// STEPS (for ascending order)
        /// 1. Gap is calculated by dividing the number of elements by 2
        /// 2. Compare element after the gap
        /// 3. Swap elements if needed
        /// 4. Move on to the next and do a comparison of the left and right after the gap
        /// 5. Divide the gap by 2 and repeat steps 2-4
        /// 6. Repeat until gap < 0
        /// 
        /// TIME COMPLEXITY
        /// * BEST: O(n log n)  ;  Worst: O(n^2)  ;  Average O(n^(3/2));
        /// 
        /// SPACE COMPLEXITY
        /// * O(1) (in place)
        /// 
        /// BEST USE CASES
        /// * Medium-sized datasets, performance is important by simplicity is a priority
        /// 
        /// PROS
        /// * Faster than the insertion, bubble and selection sort on medium sized arrays
        /// * Can be adaptive base on the gap sequence
        /// 
        /// CONS
        /// * Not stable (can change the relative order of equal elements)
        /// * Worst case performance can still be a O(n^2)
        /// * Gap sequence heavily influences performances (different gap sequences lead to very different performances)
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void ShellSort(int[] arr)
        {
            int gap = arr.Length / 2;
            int i, j;
            int temp;

            while (gap > 0) //Until there is no longer a gap
            {
                i = gap; //i will hold the gap value
                while (i < arr.Length) //Keep going while the gap is less than the array length
                {
                    temp = arr[i]; //temp holds the number in the middle
                    j = i - gap; //j holds the number starting at index 0++ (every loop)
                    while (j >= 0 && arr[j] > temp) //Check j is greater than 0 and arr[j] is greater than the temp (to stay in order)
                    {
                        arr[j + gap] = arr[j]; //Do a swap if needed (j + gap = i)
                        j = j - gap; //Revert j to its original value
                    }
                    arr[j + gap] = temp; //temp is the position the number is supposed to be
                    i++; //Continue down the array
                }
            }
        }


        static void MergeSort(int[] arr)
        {

        }

        #region Display Methods
        static void DisplayArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Write(i + " ");
            }
            WriteLine("\n\n");
        }
        static void DisplayArray(int[] arr, int[] sortedArr)
        {
            WriteLine("ARRAY: ");
            foreach(int i in arr)
            {
                Write(i + " ");
            }
            WriteLine("\n");
            WriteLine("SORTED ARRAY: ");
            foreach(int i in sortedArr) 
            {
               Write(i + " ");
            }
            WriteLine("\n\n");
        }

        #endregion Display Methods

    }
}
