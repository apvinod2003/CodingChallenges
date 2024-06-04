using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Others
{
    public class ExcelSheetColumnNumber
    {
        public int TitleToNumber(string columnTitle)
        {
            int result = 0, multiplyFactor = 1;
            for (int i = columnTitle.Length-1; i >= 0; i--)
            {
                result += (columnTitle[i] - 64) * multiplyFactor;
                multiplyFactor *= 26;
            }

            return result;
        }
    }
}
