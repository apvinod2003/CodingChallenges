namespace LeetCodeSolutions.ArraysAndStrings
{
    public class ValidPalindromeClass
    {
        /// <summary>
        /// Approach: Use two pointer method from front and rear. Keep comparing charat(left) and charat(right) untill left crosses right and return true
        /// Return false on first non match. Move pointers further left/right, as you see nonalphanumeric characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindrome(string s)
        {
            //empty strings are to be treated as palindromes,so return true.
            if (string.IsNullOrWhiteSpace(s)) 
                return true;

            int l = 0, r = s.Length-1;

            while (l < r)
            {
                while (l < r && !Char.IsLetterOrDigit(s[l]))
                    l++;
                while (r > l && !Char.IsLetterOrDigit(s[r]))
                    r--;
                if (Char.ToLower(s[l]) != Char.ToLower(s[r]))
                    return false;
                l++;
                r--;
            }

            return true;

        }
    }
}
