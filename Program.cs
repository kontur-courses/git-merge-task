using System;
using System.Collections.Generic;

namespace Kontur.Courses.Git
{
	class Program
	{
		private static void Main()
		{
			Calculator calculator = new Calculator();
			RunLoop(calculator);
		}

		private static void RunLoop(Calculator calculator)
		{
			while (true)
			{
				var line = Console.ReadLine();
				if (line == null) break;
				var args = Calculator.SplitInput(line);
				var result = calculator.Calculate(args);
				Console.WriteLine("> " + result);
			}
		}
	}
}
