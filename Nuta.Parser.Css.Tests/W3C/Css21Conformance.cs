using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.W3C
{
	[TestClass]
	public class Css21Conformance
	{
		/// <summary>
		/// Returns test files collection.
		/// </summary>
		private IEnumerable<string> GetTestFiles()
		{
			string basePath = Assembly.GetExecutingAssembly().Location;
			string rootPath = Path.GetDirectoryName(
				Path.GetDirectoryName(
					Path.GetDirectoryName(
						Path.GetDirectoryName(basePath))));

			return Directory.EnumerateFiles(
				Path.Combine(rootPath, @"W3C\ccs21-conformance"),
				"*.css",
				SearchOption.AllDirectories);
		}

		[TestMethod]
		public void Css21_Conformance_Check()
		{
			int count = 0;
			int failed = 0;
			string failedFileName = null;

			//xxx add multithreading
			//xxx check memory leaks
			foreach (string testFile in GetTestFiles().Take(200))
			{
				string data = Parser.ReadDataFromFile(testFile);
				count += 1;

				if (!CssParser.TryParse(Stylesheet.S, data))
				{
					failed += 1;
					failedFileName = Path.GetFileName(testFile);
				}
			}

			if (failed > 0)
			{
				throw new AssertFailedException(
					String.Format(
						"{0} of {1} tests are failed ({2}).",
						failed,
						count,
						failedFileName));
			}
		}
	}
}
