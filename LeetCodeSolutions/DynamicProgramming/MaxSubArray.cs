namespace LeetCodeSolutions.DynamicProgramming
{
    public class MaxiSubArray
    {

        public int MaxSubArray(int[] nums)
        {
            int currentSum = nums[0], largestSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                //if existing currentSum is negative, discard currentsum and take num[i] as curentsum.. else add num[i] to current sum.
                currentSum = int.Max(nums[i], nums[i] + currentSum );

                //largestSum is max of largestSum and currentSum
                largestSum = int.Max(largestSum, currentSum);
            }

            return largestSum; 
        }
    }
}
