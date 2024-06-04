using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Others
{
    public class FindSingleNumber
    {
        private HashSet<int> set = new HashSet<int>();
        /// <summary>
        /// Using Hashset. add to hashset if it doesn't contain the value, else remove from hashset.
        /// The one element remaining in hashset is the single number.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            foreach(int i in nums)
            {
                if(set.Contains(i))
                    set.Remove(i);
                else
                    set.Add(i);
            }

            return set.ElementAt(0);
        }

        /// <summary>
        /// Using Bitwise XOR operator.
        /// Declare an int diff and keep doing a bitwise XOR (^) with all elements in array.
        /// Logic: Duplicates will have 1 or 0 in the same positions.. so XOR will cancel them out. And the Single number will remain at last.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public  int SingleNumber1(int[] nums)
        {
            var diff = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                diff ^= nums[i];
            }
            return diff;
        }
    }
}
