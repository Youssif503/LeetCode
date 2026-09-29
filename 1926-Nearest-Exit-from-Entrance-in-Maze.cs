public class Solution {
    private readonly int[] dir = {0,1,0,-1,0};
    bool IsValid(int x,int y,int row,int col)
    {
        return x >=0 && x<row && y>=0 && y <col ;
    }
    public int NearestExit(char[][] maze, int[] entrance) 
    {
        int row = maze.Length , col = maze[0].Length;
        bool[][] visited = new bool[row][];
        int[][] distance = new int[row][];
        for(int i=0;i<row;i++)
        {
            visited[i] = new bool[col];
            distance[i] = new int[col];
        }

        Queue<(int x, int y)> queue = new();
        queue.Enqueue((entrance[0], entrance[1]));
        visited[entrance[0]][entrance[1]] = true;
        distance[entrance[0]][entrance[1]] = 0;

        while(queue.Count > 0){
            var (x,y) = queue.Dequeue();

            if ((x == 0 || x == row - 1 || y == 0 || y == col - 1) &&
                (x != entrance[0] || y != entrance[1]))
            {
                  return distance[x][y];
            }             
            for(int i=0;i<4;i++)
            {
                int newx = x + dir[i];
                int newy = y + dir[i + 1];
                if(IsValid(newx,newy,row,col) && maze[newx][newy] == '.' && visited[newx][newy] == false){

                queue.Enqueue((newx,newy));
                visited[newx][newy] = true;
                distance[newx][newy] = distance[x][y] +1 ;
                }
            }
        }
        return -1;
    }
}