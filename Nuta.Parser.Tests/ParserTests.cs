using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Lexical;

namespace Nuta.Parser.Tests
{
	[TestClass]
	public class ParserTests
	{
		[TestMethod]
		public void Filtering_Inclusive_1()
		{
			var entries = new List<LexicalEntry>
			{
				new LexicalEntry("A", 0, 2),
				new LexicalEntry("B", 0, 1),
				new LexicalEntry("C", 1, 2)
			};

			var result = entries.FilterInclusive();
			Assert.AreEqual(1, result.Count);
			Assert.AreEqual("A", result[0].Key);
		}

		[TestMethod]
		public void Filtering_Inclusive_2()
		{
			var entries = new List<LexicalEntry>
			{
				new LexicalEntry("A", 0, 1),
				new LexicalEntry("B", 1, 2),
				new LexicalEntry("C", 0, 2)
			};

			var result = entries.FilterInclusive();
			Assert.AreEqual(1, result.Count);
			Assert.AreEqual("C", result[0].Key);
		}

		[TestMethod]
		public void Filtering_Inclusive_3()
		{
			var entries = new List<LexicalEntry>
			{
				new LexicalEntry("A", 0, 8),
				new LexicalEntry("B", 4, 12),
				new LexicalEntry("C", 9, 16)
			};

			var result = entries.FilterInclusive();
			Assert.AreEqual(3, result.Count);
		}

		[TestMethod]
		public void Filtering_Inclusive_4()
		{
			var entries = new List<LexicalEntry>
			{
				new LexicalEntry("A", 0, 5),
				new LexicalEntry("B", 5, 10),
				new LexicalEntry("C", 10, 15)
			};

			var result = entries.FilterInclusive();
			Assert.AreEqual(3, result.Count);
		}

		[TestMethod]
		public void Filtering_Inclusive_5()
		{
			var entries = new List<LexicalEntry>
			{
				new LexicalEntry("A", 0, 5),
				new LexicalEntry("B", 6, 10),
				new LexicalEntry("C", 11, 15)
			};

			var result = entries.FilterInclusive();
			Assert.AreEqual(3, result.Count);
		}
	}
}
