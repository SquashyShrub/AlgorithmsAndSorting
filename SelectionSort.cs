namespace SortingPractice
{
    public class SelectionSort
    {
        public void sort(int[] arr)
        {
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
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minPos = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minPos])
                        minPos = j;
                }
                if (minPos != i)
                {
                    swap(ref arr[i], ref arr[minPos]);
                }
            }
        }
        void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}