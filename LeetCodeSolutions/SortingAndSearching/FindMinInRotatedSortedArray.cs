namespace LeetCodeSolutions.SortingAndSearching
{
    public class FindMinInRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            if(nums.Length == 1) return nums[0]; // empty or only 1 element.

        
            int left = 0, right = nums.Length - 1, mid = nums.Length / 2;

            while(left < right)
            {
                if (nums[left] == nums[mid] && nums[mid] == nums[right]) //in case there are duplicate elements.
                {
                    left++;
                    right--;
                }
                if (nums[left] < nums[right]) // already sorted.
                {
                    return nums[left];
                }

                if (nums[left] > nums[mid]) // min is towards left
                {
                    right = mid;
                }

                else if (nums[mid] > nums[right]) // min is towards right
                {
                    left = mid + 1;
                }

                mid = (left + right) / 2;
            }

            return nums[left];
        }
    }
}
