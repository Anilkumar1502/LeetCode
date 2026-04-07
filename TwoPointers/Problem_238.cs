public interface IProductCalculator<T> {
    T[] CalculateProduct(T[] items);
    void PrintResult(T[] items);
}

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int k = nums.Length;
        int[] result = new int[k];
        
        result[0] = 1;
        for(int i = 1; i < k; i++){
            result[i] = result[i - 1] * nums[i - 1];
        }
        
        int suffix = 1;
        for(int i = k - 1; i >= 0; i--){
            result[i] *= suffix;
            suffix *= nums[i];
        }
        return result;
    }
}

public class SolutionWithPrint : Solution, IProductCalculator<int> {
    public int[] CalculateProduct(int[] nums) {
        return ProductExceptSelf(nums);
    }
    
    public void PrintResult(int[] nums) {
        int[] result = CalculateProduct(nums);
        int index = 0;
        int level = 1;
        
        while(index < result.Length) {
            int spacing = (result.Length - level) * 2;
            Console.Write(new string(' ', spacing));
            
            for(int i = 0; i < level && index < result.Length; i++) {
                Console.Write(result[index++] + " ");
            }
            Console.WriteLine();
            level++;
        }
    }
}