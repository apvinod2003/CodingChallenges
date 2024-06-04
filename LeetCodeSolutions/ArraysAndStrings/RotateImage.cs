namespace LeetCodeSolutions.ArraysAndStrings
{
    public class RotateImage
    {
        public static void Rotate(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = rows; // as it is a n * n matrix.
            int median = rows / 2;

            //Visualize matrix as concentric circles, rotate outer circle, then inner circle, till you reach the middle.
            for (int i = 0; i < median; i++)
            {
                Rotate(matrix, i, rows - 1 - i);
            }
        }

        /// <summary>
        /// Rotates one concentric circle.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        private static void Rotate(int[][] matrix, int lower, int upper)
        {
            int x = lower;
            for(int y = lower; y < upper; y++)
            {
                int targetX = x;
                int targetY = y;
                int value = matrix[x][y];
                do // until a complete rotation of one value is done.
                { 
                    (targetX, targetY, value) = MoveOneElement(matrix, targetX, targetY, value);
                } while (!(targetX == x && targetY == y));
            }
        }

        /// <summary>
        /// Given x,y find new coordinates to move value in x,y 
        /// fetch existing value in new coordinates.
        /// set matrix(newx,newy) = valuetoreplace 
        /// and return new x,y,existingvalue in new x,y.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <param name="valuetoreplace"></param>
        /// <returns></returns>
        private static (int,int, int) MoveOneElement(int[][] matrix, int x, int y, int valuetoreplace)
        {
            //find new coordinates.
            int targetX = y;
            int targetY = matrix.Length - 1 - x;

            //save value in new coordinates.
            int value = matrix[targetX][targetY];

            //replace value in new coordinate.
            matrix[targetX][targetY] = valuetoreplace;

            return (targetX, targetY, value);
        }
    }
}
