using System.Runtime;

namespace _6._ZigZag_Conversion
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			string answer = solution.Convert("AB", 1);
			Console.WriteLine(answer);
		}
	}
	public class Solution
	{
		public string Convert(string s, int numRows)
		{
			if (s.Length == 0) return "";
			if (s.Length <= numRows || numRows ==1) return s;
			int y = 0;
			bool down = true;

			List<List<char>> listOfLists = new List<List<char>>();

			for(int j = 0; j < numRows;j++)
				listOfLists.Add(new List<char>());

			for (int i = 0; i < s.Length; i++) 
			{
				listOfLists[y].Add(s[i]);
				if (down) y++;
				else y--;

				if (y == numRows-1) down = false;
				if (y == 0) down = true;
			}
			string answer = "";
			foreach (List<char> sublist in listOfLists)
			{
				foreach (char c in sublist)
				{
					answer += c;
				}
			}
			return answer;
		}
	}
}
