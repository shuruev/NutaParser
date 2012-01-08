using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nuta.Parser.Css.Tests.External
{
	[TestClass]
	public class ExernalTest
	{
		#region Service methods

		/// <summary>
		/// Gets executable file name for external test runner.
		/// </summary>
		private static string GetRunnerExecutable()
		{
			string basePath = Assembly.GetExecutingAssembly().Location;
			string rootPath = Path.GetDirectoryName(
				Path.GetDirectoryName(
					Path.GetDirectoryName(
						Path.GetDirectoryName(basePath))));

			return Path.Combine(
				rootPath,
				@"Nuta.Parser.Css.Tests.Runner\bin\Release\Nuta.Parser.Css.Tests.Runner.exe");
		}

		/// <summary>
		/// Runs external test and ensures that it is passed.
		/// </summary>
		private static void RunExternal(string testName)
		{
			Process process = Process.Start(new ProcessStartInfo
			{
				FileName = GetRunnerExecutable(),
				Arguments = testName,
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(1251),
				UseShellExecute = false
			});

			const string okMark = "=== OK";
			const string errorMark = "=== ERROR";

			string output = process.StandardOutput.ReadToEnd();
			string[] lines = output.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

			if (lines.Contains(okMark))
				return;

			string message = String.Join(
				" ",
				lines
					.SkipWhile(line => line != errorMark)
					.Skip(1));

			throw new AssertFailedException(message);
		}

		/// <summary>
		/// Runs external test and checks how long did it take.
		/// </summary>
		private static void RunExternalWithTime(string testName, TimeSpan maxAllowed)
		{
			DateTime start = DateTime.Now;
			RunExternal(testName);
			TimeSpan duration = DateTime.Now.Subtract(start);

			if (duration < maxAllowed)
				return;

			string message = String.Format(
				"Total time: {0}, allowed: {1}.",
				duration,
				maxAllowed);

			throw new AssertFailedException(message);
		}

		#endregion

		[TestMethod]
		public void W3c_Css21_Conformance_Check()
		{
			RunExternalWithTime("w3c-css21-conformance", TimeSpan.FromSeconds(20));
		}

		[TestMethod]
		public void My_Css_Random_Check()
		{
			RunExternalWithTime("my-css-random", TimeSpan.FromSeconds(10));
		}
	}
}
