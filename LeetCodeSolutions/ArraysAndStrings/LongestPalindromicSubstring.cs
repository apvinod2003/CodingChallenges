namespace LeetCodeSolutions.ArraysAndStrings
{
    public class LongestPalindromicSubstring
    {
        /// <summary>
        /// Approach: Consider each char in the string to be the middle of a palindrome string and keep checking left and right chars if they are equal 
        /// and keeping going till you see a mismatch. Store this value as longest palindromic string. Repeat this for all characters in the string. 
        /// Return the longest string found.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome(string s)
        {
            string longtestPalindrome = string.Empty;
            int longestPalindromeLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                //handle odd string length palindrome
                int l = i, r = i;
                while(l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if(r-l+1 > longestPalindromeLength)
                    {
                        longtestPalindrome = s[l..(r+1)];
                        longestPalindromeLength = r - l + 1;
                    }
                    l--;
                    r++;
                }

                //find if even string palindrome exists
                l = i; r = i + 1;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if (r - l + 1 > longestPalindromeLength)
                    {
                        longtestPalindrome = s[l..(r+1)];
                        longestPalindromeLength = r - l + 1;
                    }
                    l--;
                    r++;
                }
            }

            return longtestPalindrome;
        }
    }
}
