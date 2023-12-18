namespace _17._Letter_Combinations_of_a_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Solution solution = new Solution();
            List<string> test = (List<string>)solution.LetterCombinations("234");
        }
    }

    public class Solution
    {
        private IList<string> result = new List<string>();

        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length > 0) Repeat("", digits, 0);
            return result;
        }

        Dictionary<char, string> keypad = new Dictionary<char, string> {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"}
        };


        public void Repeat(string current, string digits, int i)
        {
            if (i >= digits.Length) result.Add(current);
            else
            {
                var chars = keypad[digits[i]];
                foreach (var c in chars)
                {
                    Console.WriteLine(current+c);
                    Repeat(current + c, digits, i + 1);
                }
            }
        }
    }
}
