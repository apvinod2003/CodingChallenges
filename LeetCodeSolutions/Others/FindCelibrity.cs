using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Others
{
    public class FindCelibrity
    {
        public int FindCelebrity(int n)
        {
            int celebrity = 0;
            for (int i = 1; i < n ; i++)
            {
                if (Knows(celebrity, i))
                    celebrity = i;
            }

            for (int i = 0; i < n; i++)
            {
                if ((celebrity != i) && (Knows(celebrity, i) || (!Knows(i, celebrity))))
                    return -1;
            }

            return celebrity;
        }

        private bool Knows(int a, int b) {
            return true;
        }
    }
}
