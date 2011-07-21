using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical;
using NutaParser.Lexical.Grammar;
using NutaParser.Syntactic;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			List<LexicalEntry> data = new List<LexicalEntry>();
			data.Add(new LexicalEntry("xxx", 0, 5));
			data.Add(new LexicalEntry(Identifier.S.Key, 6, 8));
			data.Add(new LexicalEntry("xxx", 10, 16));
			SyntacticState state = new SyntacticState(data, "float Abc double");
			bool parsed = FloatingPointType.S.Parse(state);

			int z = 10;
		}
	}
}
