using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
	class Palindrome
	{
		public static bool IsPalindrome(string inputData)
		{
			int min = 0;
			int max = inputData.Length - 1;
			while (true)
			{
				if (min > max)
				{
					return true;
				}
				char stringBeggining = inputData[min];
				char stringEnding = inputData[max];

				// Scan forward for stringBeggining while invalid.
				while (!char.IsLetterOrDigit(stringBeggining))
				{
					min++;
					if (min > max)
					{
						return true;
					}
					stringBeggining = inputData[min];
				}

				// Scan backward for stringEnding while invalid.
				while (!char.IsLetterOrDigit(stringEnding))
				{
					max--;
					if (min > max)
					{
						return true;
					}
					stringEnding = inputData[max];
				}

				if (char.ToLower(stringBeggining) != char.ToLower(stringEnding))
				{
					return false;
				}
				min++;
				max--;
			}
		}
	}
}

