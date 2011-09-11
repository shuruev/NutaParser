using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nuta.Parser.Tests
{
	/// <summary>
	/// Some additional assertion methods.
	/// </summary>
	public static class Ensure
	{
		/// <summary>
		/// Checks whether specified code throws exception.
		/// </summary>
		public static void Throws(Action action)
		{
			bool throwed = false;

			try
			{
				action();
			}
			catch
			{
				throwed = true;
			}

			if (!throwed)
				throw new AssertFailedException("Expected exception was not thrown.");
		}
	}
}
