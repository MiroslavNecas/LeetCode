namespace _8._String_to_Integer__atoi_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string maxInt = "2147483647";
			string lowInt = "-2147483648";
			Solution solution = new Solution();
			int answer = solution.MyAtoi("      -43");
			Console.WriteLine(answer);
		}
	}

	public class Solution
	{
		public int MyAtoi(string s)
		{
			s = s.TrimStart();
			bool sign = false;
			int result = 0;
			int i = 0;

			if (s.Length == 0) return result;

			if (s[i] == '+')
			{
				sign = false;
				i++;
			}
			else if (s[i] == '-') 
			{
				sign = true;
				i++;
			}
			

			while (i < s.Length && char.IsDigit(s[i])) 
			{
				int digit = s[i] - '0';

				if (result > int.MaxValue / 10 || result == int.MaxValue / 10 && digit > 7)
				{
					if (sign) return int.MinValue;
					else return int.MaxValue;
				}

				result = result * 10 + digit;
				i++;
			}

			if (sign) return result * -1;
			else return result;

		}
	}
}
