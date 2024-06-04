namespace LeetCodeSolutions.DynamicProgramming
{
    public class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            //init an empty list sub, add first element
            List<int> sub = new List<int>();
            sub.Add(nums[0]);

            for (int i = 1; i < nums.Length; i++)
            {
                //if num is greater than last element in sub add it.
                if (nums[i] > sub.Last())
                    sub.Add(nums[i]);
                else // else perform a binary search to find the least number >= num in the sub array. And insert num in that position
                    sub[BinarySearch(sub, nums[i])] = nums[i];
            }

            return sub.Count; //return sub count.. this is the LIS.

        }

        private int BinarySearch(List<int> sub, int n)
        {
            int l = 0, r = sub.Count, m = (l + r) / 2;
            while (l < r)
            {
                m = (l + r) / 2;

                if (sub[m] == n)
                    return m;

                if (n < sub[m])
                    r = m;
                else
                    l = m + 1;
            }

            return l;
        }
    }
}
