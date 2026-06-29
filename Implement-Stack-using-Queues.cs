1public class MyStack
2{
3    private Queue<int> q;
4
5    public MyStack()
6    {
7        q = new Queue<int>();
8    }
9
10    public void Push(int x)
11    {
12        q.Enqueue(x);
13    }
14
15    public int Pop()
16    {
17        List<int> temp = new List<int>();
18
19        while(q.Count > 0)
20        {
21            temp.Add(q.Dequeue());
22        }
23
24        for(int i = 0; i < temp.Count - 1; i++)
25        {
26            q.Enqueue(temp[i]);
27        }
28
29        return temp[temp.Count - 1];
30    }
31
32    public int Top()
33    {
34        List<int> temp = new List<int>();
35
36        while(q.Count > 0)
37        {
38            temp.Add(q.Dequeue());
39        }
40
41        for(int i = 0; i < temp.Count; i++)
42        {
43            q.Enqueue(temp[i]);
44        }
45
46        return temp[temp.Count - 1];
47    }
48
49    public bool Empty()
50    {
51        return q.Count == 0;
52    }
53}