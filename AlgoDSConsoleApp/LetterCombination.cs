using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoDSConsoleApp
{
    public class LetterCombination
    {
        List<string> output = new List<string>();
        Dictionary<Char, Char[]> lettersMap = new Dictionary<Char, char[]>();
        List<String> result = new List<String>();
              

   
        public IList<string> GetLetterCombinations(string digits)
        {
            lettersMap.Add('1', null);
            lettersMap.Add('2', new[] { 'a', 'b', 'c' });
            lettersMap.Add('3', new[] { 'd', 'e', 'f' });
            lettersMap.Add('4', new[] { 'g', 'h', 'i' });
            lettersMap.Add('5', new[] { 'j', 'k', 'l' });
            lettersMap.Add('6', new[] { 'm', 'n', 'o' });
            lettersMap.Add('7', new[] { 'p', 'q', 'r', 's' });
            lettersMap.Add('8', new[] { 't', 'u', 'v' });
            lettersMap.Add('9', new[] { 'w', 'x', 'y', 'z' });
            lettersMap.Add('0', null);

            StringBuilder sb = new StringBuilder();
            int pos = 0;
            LetterCombinationsFunction(digits, sb, lettersMap, result, pos);

            return result;
        }

        private static List<String> LetterCombinationsFunction(String digits, StringBuilder sb,
                Dictionary<Char, Char[]> lettersMap, List<String> result, int pos)
        {
            if (sb.Length == digits.Length)
            {
                result.Add(sb.ToString());
                return result;
            }
            lettersMap.TryGetValue(digits[pos], out char[] values);
            foreach (var v in values)
            {
                sb.Append(v);
                LetterCombinationsFunction(digits, sb, lettersMap, result, pos + 1);
                sb.Remove(sb.Length - 1, 1);
            }
            return result;
        }




    }
}
