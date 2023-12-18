namespace _14._Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] input = { "reflower", "flow", "flight" };
            string answer = solution.LongestCommonPrefix(input);
            Console.WriteLine(answer);
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string word = strs[0];
            if (strs == null || strs.Length == 0)
                return "";

            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || strs[j][i] != currentChar)
                    {
                        return word.Substring(0, i);
                    }
                }
            }
            return word;
        }
    }
}
