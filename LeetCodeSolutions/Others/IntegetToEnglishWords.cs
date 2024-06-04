using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Others
{
    public class IntegetToEnglishWords
    {
        Dictionary<int, string> intToStringMap = new Dictionary<int, string>
        {
            { 0, ""},
            { 1, "One" },
            { 2, "Two" },
            { 3, "Three" },
            { 4, "Four" },
            { 5, "Five" },
            { 6, "Six" },
            { 7, "Seven" },
            { 8, "Eight" },
            { 9, "Nine" },
            { 10, "Ten" },
            { 11, "Eleven" },
            { 12, "Twelve" },
            { 13, "Thirteen" },
            { 14, "Fourteen" },
            { 15, "Fifteen" },
            { 16, "Sixteen" },
            { 17, "Seventeen" },
            { 18, "Eighteen" },
            { 19, "Nineteen" },
            { 20, "Twenty" },
            { 30, "Thirty" },
            { 40, "Forty" },
            { 50, "Fifty" },
            { 60, "Sixty" },
            { 70, "Seventy" },
            { 80, "Eighty" },
            { 90, "Ninety" }
        };

        List<string> partToString = new List<string> { "", "Thousand", "Million", "Billion" };

        
        public string NumberToWords(int num)
        {
            if (num == 0) return "Zero";
            string word = "";
            int part = 0, multiplier = 1000, i = 0;
            while (num > 0)
            {
                part = num % multiplier;
                if (part > 0)
                    word = ProcessPart(part) + " " + partToString[i] + " " + word;
                i++;

                num = num / multiplier;
            }

            return word.TrimEnd();
        }

        private string ProcessPart(int part)
        {
            string word = "";
            if (part / 100 > 0) word += intToStringMap[part / 100] + " " + "Hundred ";

            part %= 100;

            if (part <= 20) 
                word += intToStringMap[part];
            else
                word += intToStringMap[part - (part % 10)] + " " + intToStringMap[part % 10];

            return word.TrimEnd();
        }
    }
}
