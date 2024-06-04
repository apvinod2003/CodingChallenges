namespace LeetCodeSolutions.ArraysAndStrings
{
    public class ReverseStrings
    {
        //Two pointer method start from i=0 , r = n-1 and swap characters.
        public void ReverseString(char[] s)
        {
            if(s == null || s.Length == 0) return;

            int i = 0, j = s.Length - 1;

            while(i <= j)
            {
                char c = s[i];
                s[i] = s[j];
                s[j] = c;
                i++;
                j--;
            }
        }
    }
}

