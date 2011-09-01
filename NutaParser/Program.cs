using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using NutaParser.Lexical;
using NutaParser.Lexical.Grammar;
using NutaParser.Syntactic;
using NutaParser.Syntactic.Grammar;

namespace NutaParser
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Parse(@"C:\Users\Public\GIT\GitHub\NutaParser\NutaParser\Class1.cs");
			//ParseAll(@"C:\Users\Public\VSS\SED\TFS\PDM\PDMMaintenanceTool");
			Console.WriteLine("Done.");
			Console.ReadKey();
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
			/*xxxvar files = Directory.EnumerateFiles(dirPath, "*.cs", SearchOption.AllDirectories);

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

			Console.WriteLine("Done.");*/
		}

		public static void Parse(string filePath)
		{
			string data = ReadFileData(filePath);

			SyntacticState state = ParseSyntactic(data);
			if (state == null)
				throw new InvalidOperationException("Parsing error.");
		}

		private static LexicalState ParseLexical(string data)
		{
			LexicalState lexicalState = new LexicalState(data);
			bool lexicalParsed = Input.S.Parse(lexicalState);

			if (!lexicalParsed)
				return null;

			if (!lexicalState.IsEndOfData)
				return null;

			return lexicalState;
		}

		private static SyntacticState ParseSyntactic(string data)
		{
			LexicalState lexicalState = ParseLexical(data);
			if (lexicalState == null)
				return null;

			SyntacticState syntacticState = new SyntacticState(
				lexicalState.ExtractTokens(),
				data);

			bool syntacticParsed = CompilationUnit.S.Parse(syntacticState);

			if (!syntacticParsed)
				return null;

			if (!syntacticState.IsEndOfData)
				return null;

			return syntacticState;
		}

		public static string ReadFileData(string filePath)
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

			return PrepareEndOfFile(data);
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
