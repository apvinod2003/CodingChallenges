namespace LeetCodeSolutions.SortingAndSearching
{
    public class SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
           // if (nums == null || nums.Length == 0) return -1;

            int l = 0, r = nums.Length - 1, m = 0;

            while(l <= r)
            {
                m = (l + r) / 2;
                if (target == nums[m])
                {
                    return m;
                }

                if (nums[l] <= nums[m]) // left sorted array
                {
                    if (target < nums[l] || target > nums[m]) //search right
                        l = m + 1;
                    else //target probably is between l and m
                        r = m - 1;
                }
                else //right sorted array
                {
                    if (target < nums[m] || target > nums[r]) // search left
                        r = m - 1;
                    else //target probably is between m and r
                        l = m + 1;
                }
            }

            return -1;
        }
    }
}
