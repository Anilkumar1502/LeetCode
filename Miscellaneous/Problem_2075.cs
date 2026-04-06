public class Solution {
    public string DecodeCiphertext(string encodedText, int rows) {

        int columns=encodedText.Length/rows;

        char[][] matrix=new char[rows][];
        for(int i=0;i<rows;i++)
        matrix[i]=new char[columns];

        int m=rows;
        int n=columns;
        int k=0;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(k==encodedText.Length)
                break;
                matrix[i][j]=encodedText[k];
                k+=1;
            }
        }

        StringBuilder sb=new();

        for(int i=0;i<n;i++){
            k=i;
            for(int j=0;j<m&&k<n;j++){
                sb.Append(matrix[j][k]);
                k+=1;
            }
        }
        return sb.ToString().TrimEnd();
        
    }
}
