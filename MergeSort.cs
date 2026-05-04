namespace SortingPractice
{
    public class MergeSort
    {
        /// <summary>
        /// Merge sort is a divide-and-conquer algorithm that recursively splits an array into halves,
        /// sorts them, and then merges the sorted halves back together.
        ///
        /// STEPS (for ascending order)
        /// 1. Divide: Split the array into two halves until each subarray contains a single element.
        /// 2. Conquer: Recursively sort the subarrays (a single element is considered sorted).
        /// 3. Merge: Compare elements from the subarrays and combine them into a single sorted sequence.
        /// 4. Repeat: Continue merging until the entire original array is reconstructed in order.
        ///
        /// TIME COMPLEXITY
        /// * BEST: O(n log n)  ;  Worst: O(n log n)  ;  Average: O(n log n)
        ///
        /// SPACE COMPLEXITY
        /// * O(n)
        ///
        /// BEST USE CASES
        /// * Sorting large datasets, linked lists, external sorting (datasets larger than RAM),
        ///   and applications requiring a stable sort.
        ///
        /// PROS
        /// * Guaranteed worst-case performance of O(n log n).
        /// * Stable - preserves the relative order of equal elements.
        /// * Highly efficient for sorting linked lists (doesn't require random access).
        /// * Naturally parallelizable.
        ///
        /// CONS
        /// * Requires additional O(n) space for temporary arrays.
        /// * Generally slower than Quick Sort for smaller in-memory datasets due to cache inefficiency.
        /// * Not an "in-place" sorting algorithm.
        ///
        /// </summary>
        /// <param name="arr" param name="left" param name="middle" param name="right"></param>
        private void merge(int[] arr, int left, int middle, int right)
        {
            //Find the sizes of each array to be merged
            int subArrOne = middle - left + 1;
            int subArrTwo = right - middle;

            //Create temp arrays
            int[] L = new int[subArrOne];
            int[] R = new int[subArrTwo];

            //Copy data to the temp arrays
            for (int a = 0; a < subArrOne; a++)
            {
                L[a] = arr[left + a];
            }
            for (int b = 0; b < subArrTwo; b++)
            {
                R[b] = arr[middle + 1 + b];
            }

            ///Merge Temp Arrays
            //Initial indices of first and second subarrays
            int i = 0, j = 0;
            
            //Initial index of merged subarray array
            int k = left;
            while (i < subArrOne && j < subArrTwo)
            {
                if (L[i] < R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            //Copy remaining elements
            while (i < subArrOne)
            {
                arr[k] = L[i];
                k++;
                i++;
            }
            while (j < subArrTwo)
            {
                arr[k] = R[j];
                k++;
                j++;
            }
        }

        public void sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                //Find Middle Point
                int middle = left + (right - left) / 2;

                //Sort first and second halves
                sort(arr, left, middle);
                sort(arr, middle + 1, right);

                //Merge sorted Halves
                merge(arr, left, middle, right);
            }
        }

    }
}