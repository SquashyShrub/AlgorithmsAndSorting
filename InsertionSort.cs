namespace SortingPractice
{
    public class InsertionSort
    {
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
        public void sort(int[] arr)
        {
            int temp; //Variable we are trying to insert
            int position = 0; //Starting pos to checked
            
            for (int i = 1; i < arr.Length; i++) 
            {
                temp = arr[i];
                position = i;

                //Move all larger elements up until we find the correct position for temp
                while (position > 0 && arr[position - 1] > temp)
                {
                    arr[position] = arr[position - 1];
                    position--;
                }
                arr[position] = temp;
            }
        }
    }
}