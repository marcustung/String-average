using NUnit.Framework;
using String_average;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_average.Tests
{
	[TestFixture()]
	public class KataTests
	{
		[Test()]
		[TestCase("zero nine five two", "four")]
		[TestCase("four six two three", "three")]
		[TestCase("one two three four five", "three")]
		[TestCase("five four", "four")]
		[TestCase("zero zero zero zero zero", "zero")]
		[TestCase("one one eight one", "two")]
		[TestCase("", "n/a")]
		public void StringAverageTest(string str, string result)
		{
			// Arrange
			Kata kata = new Kata();

			// Act 
			string stringAverage = kata.StringAverage(str);

			// Assert
			Assert.AreEqual(stringAverage, result);
		}
	}
}