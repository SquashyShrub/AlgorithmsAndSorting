using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingPractice {
    public class BubbleSort {
        /// <summary>
        /// Bubble sort is a simple comparison-based algorithm where adjacent elements are repeatedly swapped if they are in the wrong order.
        /// 
        /// STEPS (for ascending order)
        /// 1. Compare consectuive elements    (34 -- 12) 56 78 23
        /// 2. After comparison, determine if swap is needed    (12 -- 34) 56 78 23
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
        public void sort(int[] arr)
        {
            int temp; //For the swap
            int pass; //To determine how many times to check consecutive elements
            for (pass = arr.Length - 1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                    }
                }
            }
            void Swap(ref int num1, ref int num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

        }
    }
}