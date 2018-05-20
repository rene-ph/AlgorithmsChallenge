using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges
{
	[TestClass]
	public class ReverseIntegerTest
	{
		[TestMethod()]
		public void ReverseNumberTest()
		{
			Challenge2 ch2 = new Challenge2();
			Assert.AreEqual(-321, ch2.ReverseNumber(-123));
		}

		[TestMethod()]
		public void Reverse2568()
		{
			Challenge2 ch2 = new Challenge2();
			Assert.AreEqual(8652, ch2.ReverseNumber(2568));
		}

		[TestMethod()]
		public void Reverse120()
		{
			Challenge2 ch2 = new Challenge2();
			Assert.AreEqual(21, ch2.ReverseNumber(120));
		}
	}
}
