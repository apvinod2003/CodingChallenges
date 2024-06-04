namespace LeetCodeSolutions.BackTracking
{
    public class LetterCombinationOfPhone
    {
        private static IList<string> result = new List<string>();

        private static string _digits;

        private static Dictionary<char, string> dict = new Dictionary<char, string> 
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs"},
            { '8', "tuv" },
            { '9', "wxyz"},

        };
        public static IList<string> LetterCombinations(string digits)
        {
            if (digits == null || digits.Length == 0) return null;
            _digits = digits;
            BackTrack(0, "");
            return result;
        }

        private static void BackTrack(int index, string val)
        {
            if(val.Length == _digits.Length)
            {
                result.Add(val);
                return;
            }

            foreach(var c in dict[_digits[index]])
            {
                BackTrack(index + 1, val + c);
            }

        }
    }
}
