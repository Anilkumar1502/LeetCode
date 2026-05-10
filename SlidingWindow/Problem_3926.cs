public class Solution {
    public int[] CountWordOccurrences(string[] chunks, string[] queries) {

        StringBuilder sb=new();

        foreach(var c in chunks){
            sb.Append(c);
        }
        sb.Append(' ');

        string final=sb.ToString();

        int[] ans=new int[queries.Length];

        int j=0;
        int hy=0;
        Dictionary<string,int> dic=new();
        // foreach(var word in res){
        //    if(!dic.ContainsKey(word)){
        //        dic[word]=0;
        //    }
        //     dic[word]+=1;
        // }
        for(int i=0;i<final.Length;i++){
            if(final[i]==' '){
                if(i==j)
                j+=1;
                else{
                string k=final.Substring(j,i-j-hy);
                    if(!dic.ContainsKey(k))
                    {
                        dic[k]=0;
                    }
                    dic[k]+=1;
                    j=i+1;
                  //  Console.WriteLine(k);
                }
                
            }
            else if(final[i]=='-'){
                if(i==j)
                j+=1;

                else{
                if(hy==0)
                { 
                    hy=1;
                    continue;
                }
                string k=final.Substring(j,i-j-1);
                if(!dic.ContainsKey(k))
                {
                    dic[k]=0;
                }
                dic[k]+=1;
                j=i+1;
                hy=0;
                //Console.WriteLine(k);
                }
            }
            else{
                hy=0;
            }
        }

 

        for(int i=0; i<queries.Length;i++){
            string word=queries[i];
            if(dic.ContainsKey(word)){
                ans[i]=dic[word];
            }
        }
        return ans;
    }
}
