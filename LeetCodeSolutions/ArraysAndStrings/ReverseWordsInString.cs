namespace LeetCodeSolutions.ArraysAndStrings
{
    /// <summary>
    /// Input: s = "the sky is blue"
    /// Output: "blue is sky the"
    /// Input: s = "  hello world  "
    /// Output: "world hello"
    /// 
    /// T: O(n), S: O(1)
    /// </summary>
    public class ReverseWordsInString
    {
        public string ReverseWords(string s)
        {
            if(string.IsNullOrWhiteSpace(s)) 
                return string.Empty;

            //init two variables one to point to start of a word, another to point to end of word.
            int i = 0, j=0;
            string reversedstring = string.Empty;

            while(i < s.Length) 
            {
                //advance i untill you find start of word.
                while (i < s.Length && s[i] ==  ' ')
                {
                    i++;
                }

                //at this moment i has reached the start of word OR i reached end of entire string.

                j = i; //init j to i which is start of a word.

                //advance j till end of word
                while (j < s.Length && s[j] != ' ')
                { 
                    j++; 
                }

                //at this moment j has reached the end of word OR j reached end of entire string.

                if (i == j) break; // we've reached the end.

                reversedstring = string.IsNullOrWhiteSpace(reversedstring) ?  s[i..j] : s[i..j] + " " + reversedstring; // note we need to reverse the string sequence. Handle edge cases like first itertion to avoid leading/trailing spaces.

                i = j; // set i to end of word and repeat the process.
            }

            return reversedstring;
        }
    }
}
