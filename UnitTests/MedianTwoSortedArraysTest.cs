using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod()]
		public void MedianOf13and2()
		{
			int[] num1 = new int[] { 1, 3 };
			int[] num2 = new int[] { 2 };

			Challenge3 ch3 = new Challenge3();

			Assert.AreEqual(2.0, ch3.FindMedianSortedArrays(num1, num2));
		}

		[TestMethod]
		public void MedianOf12and34()
		{
			int[] num1 = new int[] { 1, 2 };
			int[] num2 = new int[] { 3, 4 };

			Challenge3 ch3 = new Challenge3();

			Assert.AreEqual(2.5, ch3.FindMedianSortedArrays(num1, num2));
		}

		[TestMethod]
		public void MedianOfEmptyand1()
		{
			int[] num1 = new int[] { };
			int[] num2 = new int[] { 1 };

			Challenge3 ch3 = new Challenge3();

			Assert.AreEqual(1.0, ch3.FindMedianSortedArrays(num1, num2));
		}

		[TestMethod]
		public void MedianOfEmptyand1234()
		{
			int[] num1 = new int[] { };
			int[] num2 = new int[] { 1, 2, 3, 4 };

			Challenge3 ch3 = new Challenge3();

			Assert.AreEqual(2.5, ch3.FindMedianSortedArrays(num1, num2));
		}

		[TestMethod]
		public void MedianOf11and12()
		{
			int[] num1 = new int[] { 1, 1 };
			int[] num2 = new int[] { 1, 2 };

			Challenge3 ch3 = new Challenge3();

			Assert.AreEqual(1.0, ch3.FindMedianSortedArrays(num1, num2));
		}
	}
}
