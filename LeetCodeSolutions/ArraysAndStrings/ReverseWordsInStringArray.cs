namespace LeetCodeSolutions.ArraysAndStrings
{
    public class ReverseWordsInStringArray
    {

        /// <summary>
        /// Approach: reverse the entire array, the reverse each word in the array again.
        /// </summary>
        /// <param name="s"></param>
        public void ReverseWords(char[] s)
        {
            if (s == null || s.Length == 0) return;

            //Reverse the entire array
            reverse(s, 0, s.Length -1);

            int i = 0, j = 0;

            while (j < s.Length)
            {
                while (j < s.Length && s[j] != ' ')
                    j++;

                //reverse each word.
                reverse(s, i, j-1);
                i = j = j+1;
            }

        }

        /// <summary>
        /// This method reverses the chars in the given array from l to r.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        private void reverse(char[] s, int l, int r)
        {
            while(l <= r)
            {
                (s[l], s[r]) = (s[r], s[l]);
                l++;
                r--;
            }
        }
    }
}
