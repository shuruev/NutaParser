using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Grammar : SyntacticTest
	{
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
