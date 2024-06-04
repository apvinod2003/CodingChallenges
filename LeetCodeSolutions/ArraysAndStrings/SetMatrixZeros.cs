namespace LeetCodeSolutions.ArraysAndStrings
{
    public class SetMatrixZeros
    {
        public static void SetZeroes(int[][] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix[0].GetLength(0);

            bool firstRowZero = false;
            bool firstColumnZero = false;

            //loop thro all elements and mark the corresponding row and column headers to 0, if the current cell is 0.
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (j > 0)
                            matrix[0][j] = 0;
                        else
                            firstColumnZero = true;

                        if(i > 0)
                            matrix[i][0] = 0;
                        else
                            firstRowZero = true;
                    }
                }
            }

            //Proces all the rows/columns except the first row and column
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    //if row or column header is 0 the set the current cell to 0.
                    if (matrix[0][j] == 0 || matrix[i][0] == 0)
                        matrix[i][j] = 0;
                }
            }

            //if firstColumnZero is 0, set all the first column items to 0.
            if (firstColumnZero)
                for (int i = 0; i < rows; i++)
                    matrix[i][0] = 0;

            //if firstRowZero, then set all first row items to 0.
            if (firstRowZero)
            {
                for (int j = 0; j < cols; j++)
                    matrix[0][j] = 0;
            }
        }
    }
}
