public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // 1. Conta a frequência de cada número
        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (!count.ContainsKey(num)) {
                count[num] = 0;
            }
            count[num]++;
        }

        // 2. Cria os "baldes" onde o índice do array representa a frequência
        List<int>[] buckets = new List<int>[nums.Length + 1];
        for (int i = 0; i < buckets.Length; i++) {
            buckets[i] = new List<int>();
        }

        // 3. Coloca cada número no balde correspondente à sua frequência
        foreach (var kvp in count) {
            int frequency = kvp.Value;
            int number = kvp.Key;
            buckets[frequency].Add(number);
        }

        // 4. Percorre os baldes de trás para frente para pegar os mais frequentes
        int[] result = new int[k];
        int index = 0;
        
        for (int i = buckets.Length - 1; i >= 0 && index < k; i--) {
            foreach (int num in buckets[i]) {
                result[index] = num;
                index++;
                
                // Se já pegamos 'k' elementos, podemos encerrar
                if (index == k) {
                    return result;
                }
            }
        }

        return result;
    }
}