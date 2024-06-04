namespace LeetCodeSolutions.TreesAndGraphs
{
    public class NumberOfIslands
    {
        public static int NumIslands(char[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            int islands = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        islands++;
                        MarkIsland(grid, i, j);
                    }
                }
            }

            return islands;

        }

        private static void MarkIsland(char[][] grid, int r, int c)
        {
            //if index out of bounds, or already visited ('2') or you encounter water ('0') return
            if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == '2' || grid[r][c] == '0')
                return;

            //current cell is land ('1'). mark it as visited.
            grid[r][c] = '2';

            //traverse left right top bottom to find if adjacent cell is land ('1') and mark it as visited.
            MarkIsland(grid, r+1, c);
            MarkIsland(grid, r-1, c);
            MarkIsland(grid, r, c+1);
            MarkIsland(grid, r, c-1);

        }
    }
}

