public class Solution {
    public bool isValid(int r, int c,int grow,int gcol)
    {
        return r>=0 && r < grow && c>=0 && c<gcol;
    }
    public bool dfs(int i,int j,int r, int c, int[][] grid,bool[][] visit)
    {
        if(!isValid(i,j,r,c))
        return false;

        if(grid[i][j]==1)
        return true;

        if(visit[i][j]==true)
        return true;
        

        visit[i][j] = true;

        bool left = dfs(i,j-1,r,c,grid,visit);
        bool right = dfs(i,j+1,r,c,grid,visit);
        bool down = dfs(i+1,j,r,c,grid,visit);
        bool top  = dfs(i-1,j,r,c,grid,visit);

        return left && right && down && top;
    }
    public int ClosedIsland(int[][] grid) {
        int row = grid.Length;
        int col = grid[0].Length;
        bool[][] visit = new bool[row][];
        for (int i = 0; i < row; i++)
        {
            visit[i] = new bool[col];
        }

        int ans = 0;
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                if(visit[i][j] == false && grid[i][j]==0)
                {
                    if(dfs(i,j,row,col,grid,visit) == true){
                        ans++;
                    }
                }
            }
        }
        return ans;
    }
}