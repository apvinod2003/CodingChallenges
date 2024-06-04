namespace LeetCodeSolutions.ArraysAndStrings
{
    public class GroupAnagramsClass
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            foreach (string str in strs)
            {
                //sort the string and make it the key to the dictionary
                string sortedStr = SortStr(str);

                //string.Concat(str.OrderBy(c => c)); //to sort a string in a single line.. but slower than sorting a char array.

                if (dict.ContainsKey(sortedStr))
                {
                    dict[sortedStr].Add(str);
                }
                else
                {
                    dict[sortedStr] = new List<string>() { str };
                }
            }

            return new List<IList<string>>(dict.Values);
        }

        private static string SortStr(string str)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }
    }
}
