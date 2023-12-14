namespace _7._Reverse_Integer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			solution.Reverse(1534236469);
		}
	}

	public class Solution
	{
		public int Reverse(int x)
		{
			int reversed = 0;
			while (x!=0) 
			{
				if (reversed > int.MaxValue / 10 || reversed < int.MinValue / 10) return 0;
				reversed = reversed * 10 + x % 10;
				x = x / 10;
			}
			return reversed;
		}
	}
}
