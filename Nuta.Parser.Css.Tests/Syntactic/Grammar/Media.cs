using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Media : SyntacticTest
	{
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
