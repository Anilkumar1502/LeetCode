public class Solution {
    public int MinOperations(int[] nums) {

        int max=int.MinValue;
        for(int i=0;i<nums.Length;i++){
            max=Math.Max(max,nums[i]);
        }

        List<int> primes=new();
        bool[] isPrime=new bool[10*max+1];

        CalculatePrimes(primes,isPrime);

        // for(int i=0;i<primes.Count;i++){
        //     Console.WriteLine(primes[i]);
        // }

        int operations=0;
        for(int i=0;i<nums.Length;i++){
            int num=nums[i];
            if(i%2==1){
                if(num==2)
                {
                    operations+=2;
                }
                else{
                    if(isPrime[num]){
                        operations+=1;
                    }
                }
            }
            else{
                if(!isPrime[num]){
                    
                    int val=BinarySearch(primes,num);
                    operations+=val-num;
                }
            }
        }
        return operations;
    }

    private int BinarySearch(List<int> primes,int target){

        int idx=-1;

        int low=0;
        int high=primes.Count-1;

        while(low<=high){
            int mid=low+(high-low)/2;
            if(primes[mid]>target){
               // Console.WriteLine($"{low}- {mid} -{high}");
                idx=mid;
                high=mid-1;
            }
            else{
                
                low=mid+1;
            }
        }
      //Console.WriteLine($"{idx} {target}");
        return primes[idx];
    }


    private void CalculatePrimes(List<int> primes,bool[] isPrime){

        
        Array.Fill(isPrime,true);
        isPrime[1]=false;
        isPrime[2]=true;
        isPrime[3]=true;

        for(int i=2;i<isPrime.Length;i++){
            if(isPrime[i]){
                primes.Add(i);
                for(int j=2;i*j<isPrime.Length;j++){
                    isPrime[i*j]=false;
                }
            }
            
        }
    }
}
