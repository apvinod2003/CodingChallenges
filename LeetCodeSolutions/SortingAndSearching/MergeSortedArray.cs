namespace LeetCodeSolutions.SortingAndSearching
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)  return; 

            int insertIndex = m + n - 1; // last index of first array.

            int i = m - 1; // last non zero index of first array.

            int j = n - 1; //last index of second array.

            while (insertIndex >= 0 && j >=0) // loop untill all elements are inserted or nums2 has elements.
            {
                if(i < 0 || (nums2[j] > nums1[i])) //either item in num2 is greater than num1 or num1 index is already 0.
                {
                    nums1[insertIndex] = nums2[j];
                    j--;
                }
                else 
                {
                    nums1[insertIndex] = nums1[i];
                    i--;
                }
                
                insertIndex--;
            }

            
        }
        //public void Merge(int[] nums1, int m, int[] nums2, int n)
        //{
        //    if(n == 0) { return; }

        //    int insertIndex = m + n - 1; // last index of first array.

        //    int i = m - 1; // last non zero index of first array.

        //    int j = n - 1; //last index of second array.

        //    while(i >= 0 && j >= 0) 
        //    {
        //        if (nums1[i] > nums2[j]) 
        //        {
        //            nums1[insertIndex] = nums1[i];
        //            i--;
        //        }
        //        else
        //        {
        //            nums1[insertIndex] = nums2[j];
        //            j--;
        //        }
        //        insertIndex--;
        //    }

        //    while(j >= 0)
        //    {
        //        nums1[insertIndex] = nums2[j];
        //        j--;
        //        insertIndex--;
        //    }
        //}
    }
}
