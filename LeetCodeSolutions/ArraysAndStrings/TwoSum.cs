namespace LeetCodeSolutions.ArraysAndStrings
{
    public class TwoSumClass
    {
        /// <summary>
        /// Approach: a + b = target. target - a = b.
        /// loop thro the array; keep adding the items a to a dictionary <a, index> while checking if the target - a = b is present in the dictionary.
        /// If present, return both the indexes. 
        /// After iteraing all the elements in array, if you don't find b, return empty array
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();

            for(int i = 0; i<nums.Length; i++) 
            {
                //
                if (dict.ContainsKey(target - nums[i])) 
                    return [dict[target - nums[i]], i];

                dict.Add(nums[i], i);
            }

            return [];
        }
    }
}
