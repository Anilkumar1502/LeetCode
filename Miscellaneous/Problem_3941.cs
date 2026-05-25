public class Solution {
    public int PasswordStrength(string password) {

        HashSet<char> pass=new();

        string special="!@#$";

        int score=0;
        foreach(var c in password){
            if(pass.Contains(c))
            continue;
            
            if(special.Contains(c)){
                score+=5;
            }
            else if(c>='0'&&c<='9'){
                score+=3;
            }
            else if(c>='A'&&c<='Z'){
                score+=2;
            }
            else if(c>='a'&&c<='z'){
                score+=1;
            }
            pass.Add(c);
        }
        return score;
    }
}
