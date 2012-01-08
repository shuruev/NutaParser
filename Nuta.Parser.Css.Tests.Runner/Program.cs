using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Runner
{
	/// <summary>
	/// Runs external CSS test suites.
	/// </summary>
	public static class Program
	{
		private static readonly TimeSpan s_reportEvery = TimeSpan.FromSeconds(1);

		private static List<string> s_all;
		private static List<string> s_failed;
		private static int s_done;
		private static DateTime s_lastReport;

		/// <summary>
		/// Main program entry.
		/// </summary>
		public static void Main(string[] args)
		{
			bool manual = false;

			if (args.Length == 0)
			{
				manual = true;

				args = new[]
				{
					"w3c-css21-conformance"
					//"my-css-random"
				};
			}

			string folderName = args[0];

			s_all = GetTestFiles(folderName).ToList();
			s_failed = new List<string>();
			s_done = 0;
			s_lastReport = DateTime.Now;

			Console.WriteLine("{0} tests found.", s_all.Count);
			Parallel.ForEach(s_all, CheckOne);
			Console.WriteLine("Done.");
			Console.WriteLine();

			if (s_failed.Count == 0)
			{
				Console.WriteLine("=== OK");
			}
			else
			{
				Console.WriteLine("=== ERROR");

				Console.WriteLine(
					"{0} of {1} tests were failed:",
					s_failed.Count,
					s_all.Count);

				foreach (string failed in s_failed)
				{
					Console.WriteLine(Path.GetFileName(failed));
				}
			}

			if (manual)
			{
				Console.ReadKey();
			}
		}

		/// <summary>
		/// Checks specified file.
		/// </summary>
		private static void CheckOne(string testFile)
		{
			string data = Parser.ReadDataFromFile(testFile);

			lock (s_all)
			{
				s_done += 1;
				if (DateTime.Now.Subtract(s_lastReport) > s_reportEvery)
				{
					Console.WriteLine(
						"... {0} done ({1}%)",
						s_done,
						Convert.ToInt32((double)s_done / s_all.Count * 100));

					s_lastReport = DateTime.Now;
				}
			}

			if (!CssParser.TryParse(Stylesheet.S, data))
			{
				s_failed.Add(testFile);
			}
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
					Path.Combine("External", folderName)),
				"*.css",
				SearchOption.AllDirectories);
		}
	}
}
