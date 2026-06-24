1public class Solution {
2  bool IsValid(string path)
3  {
4    Stack<char> st = new Stack<char>();
5
6    for(int i = 0; i < path.Length; i++)
7    {
8        if(path[i] == '(')
9        {
10            st.Push('(');
11        }
12        else
13        {
14            if(st.Count == 0)
15                return false;
16
17            st.Pop();
18        }
19    }
20
21    return st.Count == 0;
22   }
23
24    void sol(string path,int n,List<string> validPathes)
25    {
26        if(path.Length == n*2)
27        {
28            if(IsValid(path))
29            {
30                validPathes.Add(path);
31            }
32            return;
33        }
34        sol(path+'(',n,validPathes);
35        sol(path+')',n,validPathes);
36    }
37    public IList<string> GenerateParenthesis(int n) 
38    {
39        List<string> ValidPathes = new List<string>();
40        string path = "";
41        sol(path,n,ValidPathes);
42        return ValidPathes;
43    }
44}