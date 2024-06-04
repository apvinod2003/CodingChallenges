namespace LeetCodeSolutions.SortingAndSearching
{
    /// <summary>
    /// Approach: Initialize low to 0, high to n.
    /// iterate i thro the array. If val at i is 0 swap with low, if 2 then swap with high, else move i to next position.
    /// </summary>
    public class SortColorsClass
    {
        public void SortColors(int[] nums)
        {
            if(nums == null || nums.Length < 2) return;

            int l = 0, i = 0, h = nums.Length - 1;

            while( h >= i)
            {
                if (nums[i] == 0)
                {
                    (nums[i], nums[l]) = (nums[l], nums[i]);
                    i++; l++;
                }

                else if (nums[i] == 1)
                {
                    i++;
                }
                else if (nums[i] == 2)
                {
                    (nums[h], nums[i]) = (nums[i], nums[h]);
                    h--;
                }
            }

        }
        
    }
}
