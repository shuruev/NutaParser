using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Lexical;
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
			//data.Add(new LexicalEntry("FFF", 1, 10));
			data.Add(new LexicalEntry("DDD", 11, 20));
			SyntacticState state = new SyntacticState(data);
			bool parsed = FloatingPointType.S.Parse(state);

			int z = 10;
		}
	}
}
