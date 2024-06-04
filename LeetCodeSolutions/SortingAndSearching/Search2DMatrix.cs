namespace LeetCodeSolutions.SortingAndSearching
{
    public class Search2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int r = matrix.Length, c = matrix[0].Length;

            int i = 0;
            while(i < r) 
            {
                if (target <= matrix[i][c - 1])
                    break;
                i++;
            }

            return i < r ? BinarySearch(matrix[i], target) : false;
        }

        private bool BinarySearch(int[] matrix, int target)
        {
            if(matrix.Length == 1)
            {
                if (matrix[0] == target) 
                    return true;
                return false;
            }

            int mid = matrix.Length / 2;
            return BinarySearch(matrix[0..mid], target) || BinarySearch(matrix[mid..matrix.Length], target);

        }
    }
}
