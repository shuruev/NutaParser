using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using NutaParser.Lexical;
using NutaParser.Lexical.Grammar;

namespace NutaParser
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//Parse(@"C:\Users\Public\GIT\GitHub\NutaParser\NutaParser\Class1.cs");
			ParseAll(@"C:\Users\Public\VSS\SED\TFS\PDM\PDMMaintenanceTool");
			return;

			//ParseAll(@"D:\OLEG\Dropbox");
			//ParseAll(@"D:\OLEG\Git");
			ParseAll(@"C:\Users\Public\GIT");
			ParseAll(@"C:\Users\Public\Mercurial");
			ParseAll(@"C:\Users\Public\TFS");
			ParseAll(@"C:\Users\Public\VSS");
		}

		public static void ParseAll(string dirPath)
		{
			var files = Directory.EnumerateFiles(dirPath, "*.cs", SearchOption.AllDirectories);

			foreach (string file in files)
			{
				Console.Write(file + "\t");
				Console.Write(new FileInfo(file).Length + "\t");

				Stopwatch sw = Stopwatch.StartNew();
				LexicalState state = Parse(file);
				sw.Stop();
				Console.Write(sw.ElapsedMilliseconds + "\t");

				Console.WriteLine(state.IsEndOfData ? "OK" : "ERROR");
				if (!state.IsEndOfData)
					throw new InvalidOperationException("Parsing error.");
			}

			Console.WriteLine("Done.");
		}

		public static LexicalState Parse(string filePath)
		{
			string utf8 = File.ReadAllText(filePath, Encoding.UTF8);
			string cp1251 = File.ReadAllText(filePath, Encoding.GetEncoding(1251));

			string data;
			if (utf8.Length < cp1251.Length)
			{
				data = utf8;
			}
			else if (utf8.Length == cp1251.Length)
			{
				data = cp1251;
			}
			else
			{
				throw new InvalidOperationException("Unkonwn encoding");
			}

			data = PrepareEndOfFile(data);

			LexicalState state = new LexicalState(data);
			Input.S.Parse(state);

			return state;
		}

		public static string PrepareEndOfFile(string data)
		{
			data = data.TrimEnd('\x001A');
			if (data.Length > 0)
			{
				char last = data[data.Length - 1];
				if (last != '\x000D'
					&& last != '\x000A'
					&& last != '\x2028'
					&& last != '\x2029')
				{
					data = data + '\x000D';
				}
			}

			return data;
		}
	}
}
