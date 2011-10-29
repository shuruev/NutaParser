using System;
using System.Diagnostics;
using System.IO;
using Nuta.Parser;
using Nuta.Parser.CSharp;
using Nuta.Parser.CSharp.Syntactic;
using Nuta.Parser.Css;
using Nuta.Parser.Css.Syntactic;

namespace NutaParser
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CssParser.Ensure(Stylesheet.S, "@charset 'UTF-8'; /* Theme Name: open-app */ html { margin: 0 }");

			//ParseCSharp(@"C:\Users\Public\GIT\GitHub\NutaParser\NutaParser\Class1.cs");
			//ParseCSharp(@"D:\OLEG\Git\NutaParser\NutaParser\Class1.cs");

			//ParseCSharpAll(@"D:\OLEG\Dropbox");
			//ParseCSharpAll(@"D:\OLEG\Git");

			//ParseCSharpAll(@"C:\Users\Public\GIT");
			//ParseCSharpAll(@"C:\Users\Public\Mercurial");
			//ParseCSharpAll(@"C:\Users\Public\TFS");
			//ParseCSharpAll(@"C:\Users\Public\VSS");
			//ParseCSharpAll(@"C:\Users\oshuruev\Documents\Visual Studio 2008");
			//ParseCSharpAll(@"C:\Users\oshuruev\Documents\Visual Studio 2010");

			Console.WriteLine("Done.");
			Console.ReadKey();
		}

		public static void ParseCSharpAll(string dirPath)
		{
			var files = Directory.EnumerateFiles(dirPath, "*.cs", SearchOption.AllDirectories);

			foreach (string file in files)
			{
				Console.Write(file + "\t");
				Console.Write(new FileInfo(file).Length + "\t");

				Stopwatch sw = Stopwatch.StartNew();
				ParseCSharp(file);
				sw.Stop();
				Console.WriteLine(sw.ElapsedMilliseconds + "\t");
			}
		}

		public static void ParseCSharp(string filePath)
		{
			string data = Parser.ReadDataFromFile(filePath);
			data = Parser.PrepareEndOfFile(data);

			//xxx
			if (data.Contains("unsafe")
				|| data.Contains("fixed")
				|| data.Contains("stackalloc")
				|| data.Contains("sizeof")
				|| data.Contains("public class PreProcessorDirectives : ContextBoundObject, IPerfFoo")
				|| data.Contains("#if ")
				|| data.Contains("__arglist")
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
				|| data.Contains("public class ValidInheritDoc1")
				|| data.Contains("namespace InvalidContinuationQueryClauses")
				|| data.Contains("namespace InvalidQueryClauses")
				|| data.Contains("namespace ValidQueryClauses")
				|| data.Contains("namespace ElementOrderStatics1")
				|| data.Contains("namespace ElementOrderGlobalGeneratedCode1")
				|| data.Contains("namespace LineSpacingBetweenElements1")
				|| data.Contains("namespace InterfaceMethodDeclarationClosingParenthesisPlacement1")
				|| data.Contains("namespace InterfaceMethodDeclarationCommaPlacement1")
				|| data.Contains("namespace InterfaceMethodDeclarationOpeningParenthesisPlacement1")
				|| data.Contains("namespace InterfaceMethodDeclarationParameterFollowsComma1")
				|| data.Contains("namespace InterfaceMethodDeclarationParameterListStart1")
				|| data.Contains("namespace InterfaceMethodDeclarationSpanningMultipleLines1")
				|| data.Contains("namespace InterfaceMethodDeclarationSplitParameterMustStartOnLineAfterDeclaration1")
				|| data.Contains("namespace InterfaceMethodDeclarationValidPlacement1")
				|| data.Contains("directed Primary -> Secondary availability replica pairs.")
				|| data.Contains("this.currentSite = SPControl.GetContextSite(Context)")
				|| data.Contains("namespace Micro@soft.StyleCop.CSharp")
				|| data.Contains("namespace Microsoft@.StyleCop.CSharp")
				|| data.Contains("@namespace Microsoft.StyleCop.CSharp")
				|| data.Contains("namesp\\u0061ce Microsoft.StyleCop.CSharp")
				|| data.Contains("CheckWhetherLastCodeLineIsEmpty"))
				return;

			CSharpParser.Ensure(CompilationUnit.S, data);
		}
	}
}
