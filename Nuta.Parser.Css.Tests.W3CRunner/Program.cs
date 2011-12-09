using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.W3CRunner
{
	/// <summary>
	/// Runs W3C CSS test suites.
	/// </summary>
	public static class Program
	{
		/// <summary>
		/// Main program entry.
		/// </summary>
		public static void Main(string[] args)
		{
			string folderName = "ccs21-conformance";

			int count = 0;
			int failed = 0;
			string failedFileName = null;

			//xxx add multithreading
			//xxx check memory leaks
			//for (int i = 0; i < 1000; i++)
			{
				foreach (string testFile in GetTestFiles(folderName).Skip(1000).Take(1000))
				{
					string data = Parser.ReadDataFromFile(testFile);
					count += 1;

					if (!CssParser.TryParse(Stylesheet.S, data))
					{
						failed += 1;
						failedFileName = Path.GetFileName(testFile);
					}

					Console.WriteLine(Path.GetFileName(testFile));
				}

				//Console.WriteLine("Pass {0}...", i);
			}

			if (failed == 0)
			{
				Console.WriteLine("OK.");
			}
			else
			{
				Console.WriteLine(
					"{0} of {1} tests are failed ({2}).",
					failed,
					count,
					failedFileName);
			}

			Console.ReadKey();
		}

		/// <summary>
		/// Returns test files collection.
		/// </summary>
		private static IEnumerable<string> GetTestFiles(string folderName)
		{
			string basePath = Assembly.GetExecutingAssembly().Location;
			string rootPath = Path.GetDirectoryName(
				Path.GetDirectoryName(
					Path.GetDirectoryName(
						Path.GetDirectoryName(basePath))));

			return Directory.EnumerateFiles(
				Path.Combine(
					rootPath,
					Path.Combine("W3C", folderName)),
				"*.css",
				SearchOption.AllDirectories);
		}
	}
}
