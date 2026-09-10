public class Solution {
    bool IsValid(int i,int j,int row, int col){
        return i>=0 && j>=0 && i<row && j<col;
    }
    int dfs(int[][] grid1, int[][] grid2,int i,int j,int rn,int cn,bool[][] visit){
       if (!IsValid(i, j, rn, cn))
            return 1;

        if (visit[i][j])
            return 1;

        if (grid2[i][j] == 0)
            return 1;

        visit[i][j] = true;

        int isSubIsland = 1;

        if (grid1[i][j] == 0)
            isSubIsland = 0;

        isSubIsland &= dfs(grid1, grid2, i + 1, j, rn, cn, visit);
        isSubIsland &= dfs(grid1, grid2, i - 1, j, rn, cn, visit);
        isSubIsland &= dfs(grid1, grid2, i, j + 1, rn, cn, visit);
        isSubIsland &= dfs(grid1, grid2, i, j - 1, rn, cn, visit);

        return isSubIsland;
    }
    public int CountSubIslands(int[][] grid1, int[][] grid2) 
    {
        int rn = grid1.Length,cn = grid1[0].Length;
        bool[][] visit = new bool[rn][];
        for (int i = 0; i < rn; i++)
        {
            visit[i] = new bool[cn];
        }
        int ans = 0;
        for(int i=0;i<rn;i++)
        {
            for(int j=0;j<cn;j++){
                if(grid2[i][j]==1 && !visit[i][j]){
                    ans +=dfs(grid1,grid2,i,j,rn,cn,visit);
                }
            }
        }
        return ans;
    }
}