public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        
        foreach (string s in strs) {
            char[] chars = s.ToCharArray();
            System.Array.Sort(chars);
            
            string key = new string(chars);
            
            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }
            
            map[key].Add(s);
        }
        
        // Retorna convertendo os valores do dicionário para List<List<string>>
        return new List<List<string>>(map.Values);
    }
}