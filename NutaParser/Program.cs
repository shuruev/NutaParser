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
			//Parse(@"D:\OLEG\Dropbox\My Documents\Visual Studio 2010\Projects\NutaParser\NutaParser\Class1.cs");
			Parse(@"D:\OLEG\Git\My\StyleCop\Source\4.4.0.14\StyleCop\CodeLocation.cs");
			return;

			ParseAll(@"D:\OLEG\Dropbox");
			ParseAll(@"D:\OLEG\Git");
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

				Console.WriteLine(state.IsEndOfFile ? "OK" : "ERROR");
			}

			Console.WriteLine("Done.");
		}

		public static LexicalState Parse(string filePath)
		{
			string data = File.ReadAllText(filePath);
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

			LexicalState state = new LexicalState(data);
			InputSection.S.Parse(state);

			return state;
		}
	}
}
