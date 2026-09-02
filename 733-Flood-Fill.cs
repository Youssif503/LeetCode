public class Solution {
    public bool IsValid(int i,int j,int rn,int cn)
    {
        return i>=0 && i<rn && j>=0 && j<cn;
    }
    public void dfs(int[][] image,int i,int j,int rn,int cn, int oc,int nc){
        if(!IsValid(i,j,rn,cn) || image[i][j] != oc)
           return;
        
        image[i][j] = nc;

        dfs(image,i,j-1,rn,cn,oc,nc);
        dfs(image,i,j+1,rn,cn,oc,nc);
        dfs(image,i-1,j,rn,cn,oc,nc);
        dfs(image,i+1,j,rn,cn,oc,nc);
    }
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) 
    {
        int rn = image.Length;   
        int cn = image[0].Length;  
        int oc = image[sr][sc];
        if(oc != color)
        dfs(image,sr,sc,rn,cn,oc,color);
        return image;
    }
}