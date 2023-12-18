namespace _20._Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            bool answer = solution.IsValid("(){{");
            Console.WriteLine(answer);
        }
    }
    public class Solution
    {
        public bool IsValid(string s)
        {
            while (s.Contains("{}")|| s.Contains("()") || s.Contains("[]")) 
            {
                s = s.Replace("{}", "");
                s = s.Replace("()", "");
                s = s.Replace("[]", "");
            }
            if (s.Length == 0) return true;
            else return false;
        }
    }

}
