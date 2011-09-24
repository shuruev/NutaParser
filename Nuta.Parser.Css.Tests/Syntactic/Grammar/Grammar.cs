using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Grammar : SyntacticTest
	{
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
			//xxx function
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
