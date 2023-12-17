using System.Diagnostics;

namespace _11._Container_With_Most_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine("Hello, World!");
            Solution solution = new Solution();
            //Debug.Assert(solution.MaxArea(height) == 49);
            int answer = solution.MaxArea(height);
            Console.WriteLine(answer);
        }
    }

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int area = 0;
            int maxArea = 0;

            int i = 0;
            int j = height.Length - 1;
            while (i < j)
            {
                area = Math.Min(height[i], height[j]) * (j - i);
                if (area > maxArea) maxArea = area;
                if (height[i] < height[j])
                {
                    i++;
                }
                else j--;
            }
            return maxArea;
        }       
    }
}
