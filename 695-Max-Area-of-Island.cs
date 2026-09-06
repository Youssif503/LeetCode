public class Solution
{
    bool IsValid(int i, int j, int row, int column)
    {
        return i >= 0 && i < row && j >= 0 && j < column;
    }

    int dfs(int[][] grid, bool[][] visit, int i, int j, int row, int col, ref int count)
    {
        if (!IsValid(i, j, row, col))
            return 0;

        if (grid[i][j] == 0)
            return 0;

        if (visit[i][j])
            return 0;

        count++;
        visit[i][j] = true;

        dfs(grid, visit, i, j - 1, row, col, ref count);
        dfs(grid, visit, i, j + 1, row, col, ref count);
        dfs(grid, visit, i - 1, j, row, col, ref count);
        dfs(grid, visit, i + 1, j, row, col, ref count);

        return count;
    }

    public int MaxAreaOfIsland(int[][] grid)
    {
        int row = grid.Length;
        int column = grid[0].Length;

        bool[][] visit = new bool[row][];

        for (int i = 0; i < row; i++)
        {
            visit[i] = new bool[column];
        }

        int ans = 0;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (grid[i][j] == 1 && !visit[i][j])
                {
                    int count = 0;

                    int area = dfs(grid, visit, i, j, row, column, ref count);

                    ans = Math.Max(ans, area);
                }
            }
        }

        return ans;
    }
}