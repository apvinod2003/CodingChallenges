using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Others
{
    public class RomanToInteger
    {
        Dictionary<char, int> romanToInteger = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            // Add more mappings as needed
        };

        public int RomanToInt(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((i + 1 < s.Length) && romanToInteger[s[i]] < romanToInteger[s[i + 1]])
                    result -= romanToInteger[s[i]];
                else
                    result += romanToInteger[s[i]];
            }

            return result;
        }
    }
}
