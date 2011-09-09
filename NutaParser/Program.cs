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

			//ParseAll(@"D:\OLEG\Dropbox");
			//ParseAll(@"D:\OLEG\Git");

			//ParseAll(@"C:\Users\Public\GIT");
			//ParseAll(@"C:\Users\Public\Mercurial");
			//ParseAll(@"C:\Users\Public\TFS");
			//ParseAll(@"C:\Users\Public\VSS");
			//ParseAll(@"C:\Users\oshuruev\Documents\Visual Studio 2008");
			//ParseAll(@"C:\Users\oshuruev\Documents\Visual Studio 2010");

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
				Console.WriteLine(sw.ElapsedMilliseconds + "\t");
			}
		}

		public static void Parse(string filePath)
		{
			string data = Parser.ReadFileData(filePath);

			//xxx
			if (data.Contains("unsafe")
				|| data.Contains("fixed")
				|| data.Contains("stackalloc")
				|| data.Contains("sizeof")
				|| data.Contains("public class PreProcessorDirectives : ContextBoundObject, IPerfFoo")
				|| data.Contains("#if DEBUG_FILTER")
				|| data.Contains("async"))
				return;

			if (data.Contains("public class PrefixLocalCallsWithThis")
				|| data.Contains("public class CurlyBracketsEvents")
				|| data.Contains("public class DeclarationKeywordOrderConstructors")
				|| data.Contains("/// Invalid destructor header.")
				|| data.Contains("public class DocumentationIndexers")
				|| data.Contains("public class QueryExpressions")
				|| data.Contains("public class ClassMembersLocalVariables")
				|| data.Contains("public event EventHandler E4")
				|| data.Contains("public class LambdaExpressions")
				|| data.Contains("public class NestedClassesConstructorSummary")
				|| data.Contains("namespace InvalidContinuationQueryClauses")
				|| data.Contains("namespace InvalidQueryClauses")
				|| data.Contains("namespace ValidQueryClauses")
				|| data.Contains("namespace ElementOrderStatics1")
				|| data.Contains("directed Primary -> Secondary availability replica pairs.")
				|| data.Contains("object arg0, object arg1, object arg2, __arglist")
				|| data.Contains("this.currentSite = SPControl.GetContextSite(Context)")
				|| data.Contains("namespace Micro@soft.StyleCop.CSharp")
				|| data.Contains("namespace Microsoft@.StyleCop.CSharp")
				|| data.Contains("@namespace Microsoft.StyleCop.CSharp")
				|| data.Contains("namesp\\u0061ce Microsoft.StyleCop.CSharp")
				|| data.Contains("CheckWhetherLastCodeLineIsEmpty"))
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
