namespace LeetCodeSolutions.ArraysAndStrings
{
    public class SpiralMatrix
    {
        /// <summary>
        /// Approach: traverse right,down, left, up till all items are traversed.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            int left = 0, right = matrix[0].Length -1;
            int top = 0, bottom = matrix.Length -1;
            int totalItems = (right + 1) * (bottom + 1);
            
            List<int> result = new List<int>();

            while(left <= right && top <= bottom) 
            {
                //move right

                for (int i = left; i <= right; i++)
                {
                    result.Add(matrix[top][i]);
                }
                top++;

                if (result.Count == totalItems) break;

                //move down
                for (int i = top; i <= bottom; i++)
                {
                    result.Add(matrix[i][right]);
                }
                right--;

                if (result.Count == totalItems) break;

                //move left
                for (int i = right; i >= left; i--)
                {
                    result.Add(matrix[bottom][i]);
                }
                bottom--;

                if (result.Count == totalItems) break;

                //move up
                for (int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;

                if (result.Count == totalItems) break;
            }

            return result; 
        }
    }
}
