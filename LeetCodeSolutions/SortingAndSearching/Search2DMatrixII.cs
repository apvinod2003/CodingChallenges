namespace LeetCodeSolutions.SortingAndSearching
{
    public class Search2DMatrixII
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int r = matrix.Length, c = matrix[0].Length;

            int i  = matrix.Length -1 , j = 0;

            while(i >= 0 && j < c)
            {
                if (matrix[i][j] == target) 
                    return true;

                if(target < matrix[i][j]) 
                    i--; //if target less than value at cell, decrement row
                else  
                    j++; // else increase column.
            }

            return false;
        }
    }
}
