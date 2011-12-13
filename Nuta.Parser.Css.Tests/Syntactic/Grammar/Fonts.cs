using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Fonts : SyntacticTest
	{
		[TestMethod]
		public void Is_Font_Face()
		{
			Check(false, FontFace.S, "@font-face");
			Check(true, FontFace.S, "@font-face{}");
			Check(false, FontFace.S, "@ font-face{}");
			Check(false, FontFace.S, "@font - face{}");
			Check(true, FontFace.S, "@font-face {}");
			Check(true, FontFace.S, "@font-face { }   ");
			Check(true, FontFace.S, "@font-face { ;;; }");

			Check(true, FontFace.S, "@font-face{color:red}");
			Check(true, FontFace.S, "@font-face{color:red;}");
			Check(true, FontFace.S, "@font-face { color: red }");
			Check(true, FontFace.S, "@font-face { color: red; }");

			Check(true, FontFace.S, "@font-face { font-family: main; src: url(fonts/ffmeta.woff) format(\"woff\"); font-variant: discretionary-ligatures; }");
			Check(true, FontFace.S, "@font-face { font-family: STIXGeneral; src: local(STIXGeneral), url(/stixfonts/STIXGeneral.otf); unicode-range: U+000-49F, U+2000-27FF, U+2900-2BFF, U+1D400-1D7FF; }");
		}
	}
}
