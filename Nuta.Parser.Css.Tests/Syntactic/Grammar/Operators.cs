using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Operators : SyntacticTest
	{
		[TestMethod]
		public void Is_Operator()
		{
			Check(true, Operator.S, "/");
			Check(true, Operator.S, "/ ");
			Check(true, Operator.S, ",");
			Check(true, Operator.S, ", ");
			Check(false, Operator.S, "//");
		}

		[TestMethod]
		public void Is_Combinator()
		{
			Check(false, Combinator.S, String.Empty);
			Check(false, Combinator.S, " ");
			Check(false, Combinator.S, "  ");
			Check(false, Combinator.S, "   ");

			Check(true, Combinator.S, "+");
			Check(true, Combinator.S, "+ ");
			Check(false, Combinator.S, " +");
			Check(false, Combinator.S, " + ");

			Check(true, Combinator.S, ">");
			Check(true, Combinator.S, "> ");
			Check(false, Combinator.S, " >");
			Check(false, Combinator.S, " > ");

			Check(true, Combinator.S, "~");
			Check(true, Combinator.S, "~ ");
			Check(false, Combinator.S, " ~");
			Check(false, Combinator.S, " ~ ");
		}

		[TestMethod]
		public void Is_Unary_Operator()
		{
			Check(true, UnaryOperator.S, "-");
			Check(false, UnaryOperator.S, "- ");
			Check(true, UnaryOperator.S, "+");
			Check(false, UnaryOperator.S, "+ ");
			Check(false, UnaryOperator.S, "--");
		}
	}
}
