using static System.Net.Mime.MediaTypeNames;

namespace _26._Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int answer = solution.RemoveDuplicates(new int[] { 1,2,3 });
            Console.WriteLine("asnwer is: "+answer);
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            HashSet<int> visited = new HashSet<int>();
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!visited.Contains(nums[i]))
                {
                    visited.Add(nums[i]);
                    nums[index] = nums[i];
                    index++;
                }
            }
            return index;
        }
    }
}
