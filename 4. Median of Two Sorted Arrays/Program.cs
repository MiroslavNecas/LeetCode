namespace _4._Median_of_Two_Sorted_Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			int[] array1 = { 1, 2, 3, 5, 6, 7, 8 };
			int[] array2 = { 8, 11, 23, 53, 75, 87 };
			double answer = solution.FindMedianSortedArrays(array1, array2);
			Console.WriteLine(answer);
		}
	}

	public class Solution
	{
		public double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			List<int> list = new List<int>();
			double number;
			double number1, number2;

			foreach (int num in nums1)
			{
				list.Add(num);
			}
			foreach (int num in nums2)
			{
				list.Add(num);
			}
			list.Sort();

			int size = nums1.Length + nums2.Length;
			if (size % 2 == 0)
			{
				number1 = list[(size / 2) - 1];
				number2 = list[(size / 2)];
				number = (number1 + number2) / 2;
			}
			else number = list[size / 2];
			return number;
		}
	}
}
