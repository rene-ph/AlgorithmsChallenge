using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges
{
	[TestClass]
	public class PalindromeTest
	{
		[TestMethod()]
		public void IsPalindromeNegatives()
		{
			Challenge1 ch1 = new Challenge1();
			Assert.IsFalse(ch1.IsPalindrome(-52));
		}

		[TestMethod()]
		public void IsPalindromeMinor10()
		{
			Challenge1 ch1 = new Challenge1();
			Assert.IsTrue(ch1.IsPalindrome(9));
			Assert.IsTrue(ch1.IsPalindrome(8));
			Assert.IsTrue(ch1.IsPalindrome(7));
			Assert.IsTrue(ch1.IsPalindrome(6));
			Assert.IsTrue(ch1.IsPalindrome(5));
			Assert.IsTrue(ch1.IsPalindrome(4));
			Assert.IsTrue(ch1.IsPalindrome(3));
			Assert.IsTrue(ch1.IsPalindrome(2));
			Assert.IsTrue(ch1.IsPalindrome(1));
			Assert.IsTrue(ch1.IsPalindrome(0));
		}

		[TestMethod]
		public void IsPalindrome15151()
		{
			Challenge1 ch1 = new Challenge1();
			Assert.IsTrue(ch1.IsPalindrome(15151));
		}
	}
}
