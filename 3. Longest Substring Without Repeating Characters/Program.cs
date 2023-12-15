namespace _3._Longest_Substring_Without_Repeating_Characters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			int l = solution.LengthOfLongestSubstring("pwwkew");
			Console.WriteLine(l);
		}

		public class Solution
		{
			public int LengthOfLongestSubstring(string s)
			{
				HashSet<char> set = new HashSet<char>();

				int l = 0;
				int max= 0;
				for (int r = 0; r< s.Length;r++)
				{
					while (set.Contains(s[r])) 
					{
						set.Remove(s[l]);
						l++;
					}
					set.Add(s[r]);
					max = Math.Max(max, set.Count());
				}
				return max;
			}
		}
	}
}
