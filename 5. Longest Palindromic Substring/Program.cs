namespace _5._Longest_Palindromic_Substring
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			string answer = solution.LongestPalindrome("fdsafsafsdfaewfewaababababababa");
			Console.WriteLine(answer);
		}
	}
	public class Solution
	{
		public string LongestPalindrome(string s)
		{
			if (string.IsNullOrEmpty(s))
				return string.Empty;

			int maxLength = 1;  
			int start = 0;      

			for (int i = 0; i < s.Length; i++)
			{
				int left = i;
				int right = i;
				while (left >= 0 && right < s.Length && s[left] == s[right])
				{
					int currentLength = right - left + 1;
					if (currentLength > maxLength)
					{
						maxLength = currentLength;
						start = left;
					}
					left--;
					right++;
				}


				left = i;
				right = i + 1;
				while (left >= 0 && right < s.Length && s[left] == s[right])
				{
					int currentLength = right - left + 1;
					if (currentLength > maxLength)
					{
						maxLength = currentLength;
						start = left;
					}
					left--;
					right++;
				}
			}

			return s.Substring(start, maxLength);
		}
	}
}
