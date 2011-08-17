using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutaParser.Syntactic.Grammar;

namespace NutaParser.Tests.Syntactic.Grammar
{
	[TestClass]
	public class Expressions : GrammarTest
	{
		[TestMethod]
		public void Is_Argument_List()
		{
			Check(true, ArgumentList.S, "abc: 5");
			Check(true, ArgumentList.S, "abc: 5, 6, d: e");
			Check(false, ArgumentList.S, "abc: 5, 6, d: e,");
		}

		[TestMethod]
		public void Is_Argument()
		{
			Check(true, Argument.S, "abc: 5");
			Check(true, Argument.S, "abc: a");
			Check(true, Argument.S, "5");
			Check(true, Argument.S, "a");
			Check(false, Argument.S, "abc a");
			Check(false, Argument.S, "abc: !");
		}

		[TestMethod]
		public void Is_Argument_Name()
		{
			Check(true, ArgumentName.S, "abc:");
			Check(false, ArgumentName.S, "abc::");
			Check(false, ArgumentName.S, "abc");
			Check(false, ArgumentName.S, "1abc:");
		}

		[TestMethod]
		public void Is_Argument_Value()
		{
			Check(true, ArgumentValue.S, "a");
			Check(true, ArgumentValue.S, "ref a");
			Check(true, ArgumentValue.S, "out a");
			Check(false, ArgumentValue.S, "!");
			Check(false, ArgumentValue.S, "in a");
		}

		[TestMethod]
		public void Is_Primary_Expression()
		{
			Check(true, PrimaryExpression.S, "Abc<T1, T2>");

			// xxx
		}

		[TestMethod]
		public void Is_Primary_No_Array_Creation_Expression()
		{
			Check(true, PrimaryNoArrayCreationExpression.S, "\"abc\"");
			Check(true, PrimaryNoArrayCreationExpression.S, "Abc<T1, T2>");
			Check(true, PrimaryNoArrayCreationExpression.S, "((5))");
			Check(true, PrimaryNoArrayCreationExpression.S, "Abc.D<T>");

			// xxx
		}

		[TestMethod]
		public void Is_Simple_Name()
		{
			Check(true, SimpleName.S, "Abc");
			Check(true, SimpleName.S, "Abc<T>");
			Check(true, SimpleName.S, "Abc<T1, T2>");
			Check(false, SimpleName.S, "1Abc");
			Check(false, SimpleName.S, "Abc<1T>");
		}

		[TestMethod]
		public void Is_Parenthesized_Expression()
		{
			Check(true, ParenthesizedExpression.S, "(5)");
			Check(true, ParenthesizedExpression.S, "((5))");
			Check(false, ParenthesizedExpression.S, "(5))");
		}

		[TestMethod]
		public void Is_Member_Access()
		{
			Check(true, MemberAccess.S, "5.CompareTo");
			Check(true, MemberAccess.S, "a.b.c");
			Check(true, MemberAccess.S, "Abc.D<T>");
			Check(true, MemberAccess.S, "Abc.D");
			Check(true, MemberAccess.S, "bool.D<T>");
			Check(true, MemberAccess.S, "bool.D");
			Check(true, MemberAccess.S, "global::Abc.D");
			Check(true, MemberAccess.S, "global::Abc<T>.D");
			Check(false, MemberAccess.S, "global::Abc.D<T>");
			Check(false, MemberAccess.S, "Abc.D.<T>");
		}

		[TestMethod]
		public void Is_Predefined_Type()
		{
			Check(true, PredefinedType.S, "bool");
			Check(true, PredefinedType.S, "object");
			Check(false, PredefinedType.S, "null");
		}
	}
}
