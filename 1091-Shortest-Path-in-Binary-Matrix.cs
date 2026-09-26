bool[][] visit = new bool[n][];
int[][] parent = new int[n][];

for (int i = 0; i < n; i++)
{
    visit[i] = new bool[n];
    parent[i] = new int[n];
}

Queue<(int x, int y)> q = new();

q.Enqueue((0, 0));
visit[0][0] = true;
parent[0][0] = 1;

while (q.Count > 0)
{
    var (x, y) = q.Dequeue();

    if (x == n - 1 && y == n - 1)
        return parent[x][y];

    for (int i = 0; i < 8; i++)
    {
        int newx = dx[i] + x;
        int newy = dy[i] + y;

        if (IsValid(newx, newy, n, n)
            && !visit[newx][newy]
            && grid[newx][newy] == 0)
        {
            q.Enqueue((newx, newy));

            visit[newx][newy] = true;

            parent[newx][newy] =
                parent[x][y] + 1;
        }
    }
}