namespace _2._Add_Two_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{

			ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
			ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

			Solution solution = new Solution();
			ListNode result = solution.AddTwoNumbers(l1, l2);

			// Print the result
			while (result != null)
			{
				Console.Write(result.val + " ");
				result = result.next;
			}
			Console.ReadLine();
		}
	}

	public class Solution
	{
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			ListNode dummyHead = new ListNode();
			ListNode current = dummyHead;
			int carry = 0;

			while (l1 != null || l2 != null)
			{
				int x = (l1 != null) ? l1.val : 0;
				int y = (l2 != null) ? l2.val : 0;

				int sum = x + y + carry;
				carry = sum / 10;

				current.next = new ListNode(sum % 10);
				current = current.next;

				if (l1 != null) l1 = l1.next;
				if (l2 != null) l2 = l2.next;
			}

			if (carry > 0)
			{
				current.next = new ListNode(carry);
			}

			return dummyHead.next;
		}
	}

	public class ListNode 
	{
		public int val;
		public ListNode next;
		public ListNode(int val=0, ListNode next=null) 
		{
          this.val = val;
          this.next = next;
		}
	}
}
