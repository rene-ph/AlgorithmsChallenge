using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
	public class Challenge2
	{
		/// <summary>
		/// Given a 32-bit signed integer, reverse digits of an integer.
		/// </summary>
		/// <param name="number">The number to manipulate</param>
		/// <returns>The new number</returns>
		public int ReverseNumber(int number)
		{
			try 
			{
				int signNumber = Math.Sign(number);
				int absNumber = Math.Abs(number);

				var reversedNumber = absNumber.ToString().ToCharArray().Reverse();
				var newNumber = Convert.ToInt32(String.Join("", reversedNumber));

				return newNumber * signNumber;
			}
			catch(Exception e)
			{
				return 0;
			}
		}
	}
}
