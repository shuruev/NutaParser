using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Declarations : SyntacticTest
	{
		[TestMethod]
		public void Is_Declaration_List()
		{
			Check(true, DeclarationList.S, "color:#red;color:#blue");
			Check(true, DeclarationList.S, "color:#red;color:#blue;");
			Check(true, DeclarationList.S, "color: #red; color: #blue");
			Check(true, DeclarationList.S, "color: #red; color: #blue;");
			Check(true, DeclarationList.S, String.Empty);
			Check(true, DeclarationList.S, ";");
			Check(true, DeclarationList.S, ";;;");
			Check(true, DeclarationList.S, " ; ; ; ");
		}

		[TestMethod]
		public void Is_Declaration()
		{
			Check(true, Declaration.S, "color:#red");
			Check(true, Declaration.S, "color:#red ");
			Check(true, Declaration.S, "color: #red");
			Check(true, Declaration.S, "color : #red");
			Check(false, Declaration.S, "color #red");

			Check(true, Declaration.S, "width: 15px / 10cm !important");
			Check(true, Declaration.S, "width: func(15px / 10cm) !   IMPORTANT   ");
		}

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
		public void Is_Unary_Operator()
		{
			Check(true, UnaryOperator.S, "-");
			Check(false, UnaryOperator.S, "- ");
			Check(true, UnaryOperator.S, "+");
			Check(false, UnaryOperator.S, "+ ");
			Check(false, UnaryOperator.S, "--");
		}

		[TestMethod]
		public void Is_Property()
		{
			Check(true, Property.S, "prop");
			Check(true, Property.S, "PROP ");
			Check(true, Property.S, "-some-other   ");
			Check(false, Property.S, "--some");
		}

		[TestMethod]
		public void Is_Priority()
		{
			Check(true, Priority.S, "!important");
			Check(true, Priority.S, "!   IMPORTANT   ");
			Check(false, Priority.S, "!important!");
		}

		[TestMethod]
		public void Is_Expression()
		{
			Check(true, Expression.S, "5");
			Check(true, Expression.S, "a / b");
			Check(true, Expression.S, "a / -b");
			Check(true, Expression.S, "a/-b");
			Check(false, Expression.S, "a/- b");

			Check(true, Expression.S, "5px, #red");
			Check(true, Expression.S, "+5px, +#red");
			Check(true, Expression.S, "-5px, -#red");

			Check(true, Expression.S, "Abc(2, 3)");
			Check(true, Expression.S, "Abc( 2 , 3 ) ");
			Check(false, Expression.S, "Abc ( 2 , 3 )");
			Check(true, Expression.S, "Abc(2, More(3))");
		}

		[TestMethod]
		public void Is_Term()
		{
			Check(true, Term.S, "5");
			Check(true, Term.S, "+5");
			Check(true, Term.S, "-5");
			Check(false, Term.S, "+ 5");
			Check(false, Term.S, "- 5");

			Check(true, Term.S, "1.2");
			Check(true, Term.S, "1.2 ");
			Check(true, Term.S, "3%");
			Check(true, Term.S, "3% ");
			Check(true, Term.S, "4cm");
			Check(true, Term.S, "4mm ");
			Check(true, Term.S, "5em");
			Check(true, Term.S, "5ex ");
			Check(true, Term.S, "6deg");
			Check(true, Term.S, "6grad ");
			Check(true, Term.S, "7ms");
			Check(true, Term.S, "7s ");
			Check(true, Term.S, "8hz");
			Check(true, Term.S, "8khz ");
			Check(true, Term.S, "9xx");
			Check(true, Term.S, "9xx ");

			Check(true, Term.S, "\"hi\"");
			Check(true, Term.S, "\"hi\" ");
			Check(true, Term.S, "some");
			Check(true, Term.S, "some ");
			Check(true, Term.S, "url(http://some)");
			Check(true, Term.S, "url(http://some) ");
			Check(true, Term.S, "#red");
			Check(true, Term.S, "#red ");

			Check(true, Term.S, "Abc(2, 3)");
			Check(true, Term.S, "Abc( 2 , 3 ) ");
			Check(false, Term.S, "Abc ( 2 , 3 )");
			Check(true, Term.S, "Abc(2, More(3))");
		}

		[TestMethod]
		public void Is_Function()
		{
			Check(true, Function.S, "Func(5)");
			Check(true, Function.S, "Func(5, 6)");
			Check(true, Function.S, "Func( 5 , 6 ) ");
			Check(false, Function.S, "Func ( 5 , 6 )");
			Check(true, Function.S, "Func(5, More(6, 7))");
			Check(false, Function.S, "Func()");
			Check(false, Function.S, "Func(,)");
			Check(false, Function.S, "Func(5, More(6, 7)");
		}

		[TestMethod]
		public void Is_Hex_Color()
		{
			Check(true, HexColor.S, "#red");
			Check(true, HexColor.S, "#GREEN   ");
			Check(true, HexColor.S, "#0");
			Check(true, HexColor.S, "#222");
			Check(true, HexColor.S, "#aaaa");
			Check(true, HexColor.S, "#FFFFFF");
			Check(false, HexColor.S, "#");
			Check(false, HexColor.S, " #red");
			Check(false, HexColor.S, "# red");
		}
	}
}
