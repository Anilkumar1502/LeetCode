public class Solution {
    public string RemoveDuplicateLetters(string s) {

        int[] last=new int[26];

        for(int i=0;i<s.Length;i++){
            last[s[i]-'a']=i;
        }

        bool[] present=new bool[26];


        Stack<char> stack=new();

        for(int i=0;i<s.Length;i++){
            char c=s[i];
            if(present[c-'a'])
            continue;

            while(stack.Any()&&stack.Peek()>c&&last[stack.Peek()-'a']>i){
                char pop=stack.Pop();
                present[pop-'a']=false;
            }
            stack.Push(c);
            present[c-'a']=true;
        }

        char[] final=new char[stack.Count];

        for(int i=stack.Count-1;i>=0;i--){
            final[i]=stack.Pop();
        }

        return new string(final);

    }
}
