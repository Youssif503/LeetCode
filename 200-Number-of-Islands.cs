public class Solution {
    bool IsValid(int i,int j , int row , int column)
    {
        return i>=0 && i<row && j>=0 && j<column;
    }

    int dfs(bool[][] visit,char[][]grid,int i,int j,int row,int column){

        if (!IsValid(i, j, row, column))
            return 0;

        if (grid[i][j] == '0' || visit[i][j])
            return 0;
  
        visit[i][j] = true;
        dfs(visit,grid,i,j-1,row,column);
        dfs(visit,grid,i,j+1,row,column);
        dfs(visit,grid,i-1,j,row,column);
        dfs(visit,grid,i+1,j,row,column);
        return 1;
    }
    public int NumIslands(char[][] grid) {
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
                ans += dfs(visit, grid, i, j, row, column);
            }
        }
        return ans;
    }
}