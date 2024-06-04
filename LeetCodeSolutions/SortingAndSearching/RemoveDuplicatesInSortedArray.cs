namespace LeetCodeSolutions.SortingAndSearching
{
    public class RemoveDuplicatesInSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            //[0,0,1,1,1,2,2,3,3,4]

            int len = nums.Length;
            if(len < 2) return len;

            int i = 0, j = 0;

            for(j = 0; j < len; j++)
            {
                if (nums[j] == nums[i])
                    continue;
                //at this point we got the next unique value. Copy it to i+1 position.

                i++;
                nums[i] = nums[j];
            }

            return i+1;
        }
    }
}
