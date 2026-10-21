public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        
        // 1. Primeira passada: Calcula os produtos de tudo que está à ESQUERDA do número
        int prefix = 1;
        for (int i = 0; i < nums.Length; i++) {
            result[i] = prefix;
            prefix *= nums[i];
        }
        
        // 2. Segunda passada: Multiplica pelos produtos de tudo que está à DIREITA do número
        int suffix = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            result[i] *= suffix;
            suffix *= nums[i];
        }
        
        return result;
    }
}