public class Solution
{
    private readonly int[] dx =
    {
        -1, -1, -1,
         0,  0,
         1,  1,  1
    };

    private readonly int[] dy =
    {
        -1,  0,  1,
        -1,  1,
        -1,  0,  1
    };

    private bool IsValid(int x, int y, int n)
    {
        return x >= 0 &&
               x < n &&
               y >= 0 &&
               y < n;
    }

    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        int n = grid.Length;

        // Start or destination is blocked
        if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1)
            return -1;

        bool[][] visited = new bool[n][];
        int[][] distance = new int[n][];

        for (int i = 0; i < n; i++)
        {
            visited[i] = new bool[n];
            distance[i] = new int[n];
        }

        Queue<(int x, int y)> queue = new();

        queue.Enqueue((0, 0));

        visited[0][0] = true;
        distance[0][0] = 1;

        while (queue.Count > 0)
        {
            var (x, y) = queue.Dequeue();

            // We reached the destination
            if (x == n - 1 && y == n - 1)
                return distance[x][y];

            // Try all 8 directions
            for (int i = 0; i < 8; i++)
            {
                int newX = x + dx[i];
                int newY = y + dy[i];

                if (!IsValid(newX, newY, n))
                    continue;

                if (grid[newX][newY] == 1)
                    continue;

                if (visited[newX][newY])
                    continue;

                visited[newX][newY] = true;

                distance[newX][newY] =
                    distance[x][y] + 1;

                queue.Enqueue((newX, newY));
            }
        }

        return -1;
    }
}