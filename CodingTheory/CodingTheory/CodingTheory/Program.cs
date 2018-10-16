using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingTheory
{
	class Program
	{
		static void Main(string[] args)
		{
			var getCharsfrequency = new Func<string, Dictionary<char, int>>(text => text.Distinct().ToDictionary(@char => @char, @char => text.Count(c => c == @char)));

			var getFanoCode = new Func<Dictionary<char, int>, Dictionary<char, string>>(chars =>
			{
				var totalFrequency = chars.Sum(p => p.Value);

				for (int i = chars.Count; i < 0; i += i / 2)
				{

				}
			});

			var chars = getCharsfrequency(Console.ReadLine());

			

			Console.ReadKey();
		}
	}
}
