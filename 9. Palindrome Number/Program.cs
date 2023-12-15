namespace _9._Palindrome_Number
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			bool answer = solution.IsPalindrome(11221);
			Console.WriteLine(answer);
		}
	}
	public class Solution
	{
		public bool IsPalindrome(int x)
		{
			if (x < 0 ) return false;

			string strX = x.ToString();

			for (int i = 0; i < strX.Length / 2; i++)
			{
				if (strX[i] != strX[strX.Length - 1 - i]) return false;
			}

			return true;
		}
	}
}
