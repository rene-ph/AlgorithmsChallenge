using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
	public class Challenge3
	{

		/// <summary>
		/// There are two sorted arrays nums1 and nums2 of size m and n respectively.
		/// Find the median of the two sorted arrays.
		/// </summary>
		/// <param name="nums1"></param>
		/// <param name="nums2"></param>
		/// <returns>Double</returns>
		public double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			try 
			{
				List<int> mergeArray = new List<int>(nums1);
				int centerIndex = 0;
				double result = 0;

				mergeArray.AddRange(nums2);
				mergeArray.Sort();

				int totalFields = mergeArray.Count();
				if (totalFields % 2 == 0)
				{
					centerIndex = totalFields / 2;
					result = Convert.ToDouble((mergeArray[centerIndex - 1] + mergeArray[centerIndex])) / 2;
				}
				else
				{
					centerIndex = (totalFields + 1) / 2 - 1;
					result = mergeArray[centerIndex];
				}
				return result;

			}	
			catch(Exception e) 
			{	
				//TODO add log error here if needed. 
			    return 0;
			}
		}

	}
}
