1public class Solution {
2    public int CalPoints(string[] operations)
3{
4    Stack<int> st = new Stack<int>();
5
6    foreach (string op in operations)
7    {
8        if (int.TryParse(op, out int num))
9        {
10            st.Push(num);
11        }
12        else if (op == "+")
13        {
14            int first = st.Pop();
15            int second = st.Pop();
16
17            st.Push(second);
18            st.Push(first);
19            st.Push(first + second);
20        }
21        else if (op == "D")
22        {
23            st.Push(st.Peek() * 2);
24        }
25        else // C
26        {
27            st.Pop();
28        }
29    }
30
31    int sum = 0;
32
33    while (st.Count > 0)
34    {
35        sum += st.Pop();
36    }
37
38    return sum;
39}
40}