public class Solution {
    public string GenerateString(string str1, string str2) {
        
        int m=str1.Length;
        int n=str2.Length;
        char[] res=new char[n+m-1];
      //  bool[] fix = new bool[n+m-1];
        Array.Fill(res,'1');
        
        char[] nres=new char[n+m-1];
        for(int i=0;i<m;i++){
            if(str1[i]=='T'){
                bool valid=FillResultArrayT(i,str2,res);
                if(!valid)
                return string.Empty;
            }
        }
        Array.Copy(res,nres,res.Length);
        for(int i=0;i<nres.Length;i++)
         {
            if(nres[i]=='1')
             nres[i]='a';
         }
        for(int i=0;i<m;i++){
             if(str1[i]=='F'){
                bool valid=FillResultArrayF(i,str2,nres,res);
                if(!valid){
                 //  Console.WriteLine(i);
                return string.Empty;
                }
            }
        }
        var result=new string(nres);
        return result;
    }

    private bool FillResultArrayF(int idx,string s,char[] nres,char[] res){
       if(!new string(nres,idx,s.Length).Equals(s))
       return true;

       bool valid=false;
       int n=s.Length;
       for(int i=idx+n-1;i>=idx;i--){
         if(res[i]=='1'){
            nres[i]='b';
            valid=true;
            break;
         }
       }
       return valid;
    }

    private bool FillResultArrayT(int idx,string s,char[] res){

        for(int i=idx;i<idx+s.Length;i++){
            if(res[i]=='1'){
                res[i]=s[i-idx];
            }
            else{
                if(res[i]!=s[i-idx])
                return false;
            }
           // fix[i]=true;
        }
        return true;
    }
}
