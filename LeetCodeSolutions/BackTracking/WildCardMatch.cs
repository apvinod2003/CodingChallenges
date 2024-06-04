namespace LeetCodeSolutions.BackTracking
{
    public class WildCardMatch
    {

        public bool IsMatch(string s, string p)
        {
            int sLen = s.Length;
            int pLen = p.Length;
            int sIdx = 0;
            int pIdx = 0;
            int starIdx = -1;
            int sTmpIdx = -1;

            while (sIdx < sLen)
            {
                // If the pattern character = string character
                // or pattern character = '?'
                if (pIdx < pLen && (p[pIdx] == '?' || p[pIdx] == s[sIdx]))
                {
                    sIdx++;
                    pIdx++;
                }
                // If pattern character = '*'
                else if (pIdx < pLen && p[pIdx] == '*')
                {
                    // Check the situation when '*' matches no characters
                    starIdx = pIdx;
                    sTmpIdx = sIdx;
                    pIdx++;
                }
                // If pattern character != string character
                // or pattern is used up and there was no '*' character in pattern
                else if (starIdx == -1)
                {
                    return false;
                }
                // If pattern character != string character
                // or pattern is used up and there was '*' character in pattern before
                else
                {
                    // Backtrack: check the situation when '*' matches one more character
                    pIdx = starIdx + 1;
                    sIdx = sTmpIdx + 1;
                    sTmpIdx = sIdx;
                }
            }

            // The remaining characters in the pattern should all be '*' characters
            for (int i = pIdx; i < pLen; i++)
            {
                if (p[i] != '*')
                {
                    return false;
                }
            }

            return true;


        }

        //public bool IsMatch(string s, string p)
        //{
        //    bool isMatch = true;

        //    if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p) == null || string.IsNullOrEmpty(p.Replace("*",""))) { return true; }

        //    int sLen = s.Length;
        //    int pLen = p.Length;

        //    int i = 0, j = 0;

        //    while (isMatch)
        //    {
        //        if (i >= sLen && j <= pLen-1) return false;

        //        if (i <= sLen-1 && j >= pLen) return false;

        //        if(i > sLen-1 && j> pLen-1) return isMatch;

        //        if (char.IsLower(p[j]) && s[i] != p[j])
        //        {
        //            return false;
        //        }
        //        else if (char.IsLower(p[j]) && s[i] == p[j])
        //        {
        //            i++;
        //            j++;
        //            continue;
        //        }
        //        else if (p[j] == '?')
        //        {
        //            i++;
        //            j++;
        //            continue;
        //        }
        //        else if (p[j] == '*' && j >= pLen - 1) // * is in last position in pattern, so return true
        //            return true;
        //        else if (p[j] == '*' && j < pLen - 1)
        //        {
        //            j++;
        //            char c = p[j];
        //            isMatch = false;
        //            while(i <= sLen-1)
        //            {
        //                if(c == s[i])
        //                {
        //                    isMatch = true;
        //                    break;
        //                }
        //                i++;
        //            }
        //        }


        //    }

        //    return isMatch;
        //}
    }
}

