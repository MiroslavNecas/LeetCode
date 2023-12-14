namespace _1._Two_Sum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			int[] array = new int[4] { 2, 5, 5, 11 };
			int[] answer = new int[2];
			answer = solution.TwoSum(array, 10);

			Console.WriteLine(answer[0]);

			Console.WriteLine(answer[1]);
			Console.ReadLine();
		}
	}

	public class Solution
	{
		public int[] TwoSum(int[] nums, int target)
		{
			int[] answer = new int[2];
			int first = 0;
			int second = 0;

			for (int i = 0; i < nums.Length-1; i++) 
			{
				first = nums[i];
				for (int j = i+1; j < nums.Length; j++) 
				{
					second = nums[j];

					if (first + second == target)
					{
						answer[0] = i;
						answer[1] = j;
						return answer;
					}
				}
			}
			return answer;
		}
	}
}
