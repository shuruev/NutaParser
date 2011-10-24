using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Media : SyntacticTest
	{
		[TestMethod]
		public void Is_Media_Query_List()
		{
			Check(true, MediaQueryList.S, String.Empty);
			Check(true, MediaQueryList.S, " ");
			Check(true, MediaQueryList.S, "screen");
			Check(true, MediaQueryList.S, " screen");
			Check(true, MediaQueryList.S, "screen ");
			Check(true, MediaQueryList.S, " screen ");

			Check(true, MediaQueryList.S, "screen,print");
			Check(true, MediaQueryList.S, "screen, print");
			Check(true, MediaQueryList.S, "screen ,print");
			Check(true, MediaQueryList.S, "screen , print");

			Check(
				true,
				MediaQueryList.S,
				@"
					print and (min-width: 25cm),
					screen and (min-width: 400px) and (max-width: 700px),
					mobile
				");
		}

		[TestMethod]
		public void Is_Media_Query_List_Additional()
		{
			Check(true, MediaQueryList.S, Syntactic.MediaQueryList1);
			Check(true, MediaQueryList.S, Syntactic.MediaQueryList2);
			Check(true, MediaQueryList.S, Syntactic.MediaQueryList3);
			Check(true, MediaQueryList.S, Syntactic.MediaQueryList4);
			Check(true, MediaQueryList.S, Syntactic.MediaQueryList5);
			Check(true, MediaQueryList.S, Syntactic.MediaQueryList6);
			Check(true, MediaQueryList.S, Syntactic.MediaQueryList7);
			Check(true, MediaQueryList.S, Syntactic.MediaQueryList8);
			Check(true, MediaQueryList.S, Syntactic.MediaQueryList9);
			Check(true, MediaQueryList.S, Syntactic.MediaQueryList10);
		}

		[TestMethod]
		public void Is_Media_Query()
		{
			Check(true, MediaQuery.S, "screen");
			Check(true, MediaQuery.S, " screen");
			Check(true, MediaQuery.S, "screen ");
			Check(true, MediaQuery.S, "not screen");
			Check(true, MediaQuery.S, "only screen");
			Check(true, MediaQuery.S, "screen and (min-height:100px)");
			Check(true, MediaQuery.S, "screen and (min-height: 100px)");
			Check(false, MediaQuery.S, "screen and(min-height: 100px)");
			Check(true, MediaQuery.S, "screen and (min-height: 100px) and (max-height: 200px)");
			Check(true, MediaQuery.S, "screen and (min-height: 100px)and (max-height: 200px)");
			Check(true, MediaQuery.S, "screen and (min-height: 100px) and (max-height: 200px) ");

			Check(false, MediaQuery.S, "(min-height:100px)and(max-height:200px)");
			Check(false, MediaQuery.S, "(min-height:100px) and(max-height:200px)");
			Check(true, MediaQuery.S, "(min-height: 100px) and (max-height: 200px)");
			Check(true, MediaQuery.S, "(min-height: 100px) and (max-height: 200px) ");
			Check(false, MediaQuery.S, " (min-height: 100px) and (max-height: 200px)");
		}

		[TestMethod]
		public void Is_Media_Type()
		{
			Check(true, MediaType.S, "abc");
			Check(true, MediaType.S, "-abc-2");
			Check(false, MediaType.S, "--ns");
			Check(false, MediaType.S, "*");
		}

		[TestMethod]
		public void Is_Media_Expression()
		{
			Check(true, MediaExpression.S, "(min-width)");
			Check(true, MediaExpression.S, "( min-width)");
			Check(true, MediaExpression.S, "(min-width )");
			Check(true, MediaExpression.S, "(min-width) ");

			Check(true, MediaExpression.S, "(min-width:400px)");
			Check(true, MediaExpression.S, "(min-width: 400px)");
			Check(false, MediaExpression.S, "(--min)");
		}

		[TestMethod]
		public void Is_Media_Feature()
		{
			Check(true, MediaFeature.S, "abc");
			Check(true, MediaFeature.S, "-abc-2");
			Check(false, MediaFeature.S, "--ns");
			Check(false, MediaFeature.S, "*");
		}
	}
}
