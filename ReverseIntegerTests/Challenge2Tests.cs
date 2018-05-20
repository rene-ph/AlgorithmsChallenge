using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseInteger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger.Tests
{
	[TestClass()]
	public class Challenge2Tests
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