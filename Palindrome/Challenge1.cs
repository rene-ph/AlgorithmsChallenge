using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
	public class Challenge1
	{

		/// <summary>
		/// Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
		/// </summary>
		/// <param name="number">The integer to evaluate weather is a palindrome or not</param>
		/// <returns></returns>
		public bool IsPalindrome(int number)
		{
			if (number < 0)
			{
				return false;
			}
			else
			{
				var reversedNumArray = number.ToString().ToCharArray().Reverse();
				var reversedNumber = String.Join("", reversedNumArray);
				return (reversedNumber == number.ToString());
			}
		}

	}
}
