public class Solution {
    public IList<string> TwoEditWords(string[] queries, string[] dictionary) {

       IList<string> suited=new List<string>();


       for(int i=0;i<queries.Length;i++){
            string compare=queries[i];

            for(int j=0;j<dictionary.Length;j++){
                string exist=dictionary[j];

                int differ=0;
                for(int k=0;k<compare.Length&&differ<3;k++){
                    if(compare[k]!=exist[k]){
                        differ+=1;
                    }
                }
                if(differ<=2){
                    suited.Add(compare);
                    break;
                }
            }
       }

       return suited; 
    }
}
