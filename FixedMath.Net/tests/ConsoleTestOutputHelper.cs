﻿using System;
using Xunit.Abstractions;

namespace FixMath.NET
{
	class ConsoleTestOutputHelper : ITestOutputHelper
	{
		public void WriteLine(string message)
		{
			Console.WriteLine(message);
		}

		public void WriteLine(string format, params object[] args)
		{
			Console.WriteLine(format, args);
		}
	}
}
