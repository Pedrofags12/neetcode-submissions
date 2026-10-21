public class Solution {
    public string Encode(IList<string> strs) {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        
        foreach (string s in strs) {
            // Guarda o tamanho, um '#' como separador, e a própria string
            sb.Append(s.Length).Append('#').Append(s);
        }
        
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;
        
        while (i < s.Length) {
            int j = i;
            // Procura onde está o '#' para descobrir qual é o número do tamanho
            while (s[j] != '#') {
                j++;
            }
            
            // Pega o número que está antes do '#' e converte para inteiro
            int length = int.Parse(s.Substring(i, j - i));
            
            // Pula o índice 'i' para a posição logo após o '#'
            i = j + 1;
            
            // Extrai exatamente a quantidade de letras que o número mandou
            res.Add(s.Substring(i, length));
            
            // Pula o índice 'i' para o começo da próxima palavra codificada
            i += length;
        }
        
        return res;
    }
}