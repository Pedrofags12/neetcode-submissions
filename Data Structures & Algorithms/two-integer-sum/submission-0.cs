public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Dicionário para guardar o número (chave) e o seu índice (valor)
        Dictionary<int, int> prevMap = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            // Calcula qual número falta para atingir o target
            int diff = target - nums[i];
            
            // Se o número que falta já está no dicionário, achamos o par!
            if (prevMap.ContainsKey(diff)) {
                return new int[] { prevMap[diff], i };
            }
            
            // Caso contrário, guarda o número atual e sua posição no dicionário
            prevMap[nums[i]] = i;
        }
        
        // Retorno padrão de segurança (o problema garante que sempre haverá resposta)
        return new int[0];
    }
}