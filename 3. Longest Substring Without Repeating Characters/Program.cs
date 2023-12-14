namespace _3._Longest_Substring_Without_Repeating_Characters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			int l = solution.LengthOfLongestSubstring("ffdanfjdsajfsabababababaababababababajaffavaewvweavafhhdsfhasiudfhiuashufhasiaaaaaaa");
			Console.WriteLine(l);
		}

		public class Solution
		{
			public int LengthOfLongestSubstring(string s)
			{
				int ans = 0;
				int i = 0;
				Dictionary<char, int> dict = new Dictionary<char, int>();
				for (int j = 0; j < s.Length; j++)
				{
					if (dict.ContainsKey(s[j]))
					{
						i = Math.Max(dict[s[j]], i);
					}
					ans = Math.Max(ans, j - i + 1);
					dict[s[j]] = j + 1;
				}
				return ans;
			}
		}
	}
}
