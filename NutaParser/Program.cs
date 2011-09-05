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
			//Parse(@"C:\Users\Public\GIT\GitHub\NutaParser\NutaParser\Class1.cs");
			Parse(@"D:\OLEG\Git\NutaParser\NutaParser\Class1.cs");
			//ParseAll(@"C:\Users\Public\VSS\SED\TFS");

			//ParseAll(@"D:\OLEG\Dropbox");
			//ParseAll(@"D:\OLEG\Git");

			//ParseAll(@"C:\Users\Public\GIT");
			//ParseAll(@"C:\Users\Public\Mercurial");
			//ParseAll(@"C:\Users\Public\TFS");
			//ParseAll(@"C:\Users\Public\VSS");

			Console.WriteLine("Done.");
			Console.ReadKey();
		}

		public static void ParseAll(string dirPath)
		{
			var files = Directory.EnumerateFiles(dirPath, "*.cs", SearchOption.AllDirectories);

			foreach (string file in files)
			{
				Console.Write(file + "\t");
				Console.Write(new FileInfo(file).Length + "\t");

				Stopwatch sw = Stopwatch.StartNew();
				Parse(file);
				sw.Stop();
				Console.Write(sw.ElapsedMilliseconds + "\t");
			}

			Console.WriteLine("Done.");
		}

		public static void Parse(string filePath)
		{
			string data = Parser.ReadFileData(filePath);

			//xxx
			if (data.Contains("interface ")
				|| data.Contains("enum ")
				|| data.Contains("delegate ")
				|| data.Contains("struct ")
				|| data.Contains("unsafe")
				|| data.Contains("fixed")
				|| data.Contains("stackalloc")
				|| data.Contains("sizeof"))
				return;

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
	}
}
