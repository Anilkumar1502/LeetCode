public class Solution {
    public string SortVowels(string s) {

        int[][] frequency=new int[5][];

        for(int i=0;i<5;i++){
            frequency[i]=new int[3];
            frequency[i][1]=-1;
            frequency[i][2]=i;
        }

        for(int i=0;i<s.Length;i++){
            if(s[i]=='a'){
                if(frequency[0][1]==-1){
                    frequency[0][1]=i;
                }
                frequency[0][0]+=1;
            }
            else if(s[i]=='e'){
                if(frequency[1][1]==-1){
                    frequency[1][1]=i;
                }
                frequency[1][0]+=1;
            }
            else if(s[i]=='i'){
                if(frequency[2][1]==-1){
                    frequency[2][1]=i;
                }
                frequency[2][0]+=1;
            }
            else if(s[i]=='o'){
                if(frequency[3][1]==-1){
                    frequency[3][1]=i;
                }
                frequency[3][0]+=1;
            }
            else if(s[i]=='u'){
                if(frequency[4][1]==-1){
                    frequency[4][1]=i;
                }
                frequency[4][0]+=1;
            }
        }

        Array.Sort(frequency,(a,b)=>{
           if(a[0]==b[0]){
               return a[1]-b[1];
           } 
            return b[0]-a[0];
        });

        char[] sorted=s.ToCharArray();

        int j=0;
        for(int i=0;i<s.Length;i++){

            if(s[i]=='a'||s[i]=='e'||s[i]=='i'||s[i]=='o'||s[i]=='u'){
                if(frequency[j][2]==0){
                    sorted[i]='a';
                }
                else if(frequency[j][2]==1){
                    sorted[i]='e';
                }
                else if(frequency[j][2]==2){
                    sorted[i]='i';
                }
                else if(frequency[j][2]==3){
                    sorted[i]='o';
                }
                else if(frequency[j][2]==4){
                    sorted[i]='u';
                }
                frequency[j][0]-=1;
                if(frequency[j][0]==0)
                    j+=1;
            }
        }
        return new string(sorted);
    }
}
