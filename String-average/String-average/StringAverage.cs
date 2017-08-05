using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_average
{
	public class Kata
	{
		public string StringAverage(string str)
		{
			string result = string.Empty;
			int sum = 0;
			string[] numbers = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

			// verify
			if (string.IsNullOrEmpty(str))
				return "n/a";

			// replace
			for (int i = 0; i < numbers.Length; i++)
			{
				str = str.Replace(numbers[i].ToString(), i.ToString());
			}

			// split 
			string[] array = str.Split(' ');
			
			foreach (string item in array)
			{
				int itemNumber = 0;

				if (!int.TryParse(item, out itemNumber))
					return "n/a";

				sum += itemNumber;
			}
			
			result = numbers[int.Parse((sum / array.Length).ToString())];

			return result;
		}
	}
}
