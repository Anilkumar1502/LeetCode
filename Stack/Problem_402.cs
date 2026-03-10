public class Solution {
    public string RemoveKdigits(string num, int k) {

      int n=num.Length;
      if(n==k)
      return "0";

      Stack<int> stack=new();

      for(int i=0;i<n;i++){

        while(stack.Count>0&&k>0&&num[stack.Peek()]>num[i]){
            
            stack.Pop();
            k-=1;
        }
        stack.Push(i);
      }

      while(k>0){
        stack.Pop();
        k-=1;
      }

      int len=stack.Count;
      int[] revString=stack.ToArray();

     

      StringBuilder sb=new();
     
      for(int i=len-1;i>=0;i--){
        if(num[revString[i]]=='0'&&sb.Length==0)
        continue;

        sb.Append(num[revString[i]]);
      }

      return sb.Length>0?sb.ToString():"0";
    }
}
