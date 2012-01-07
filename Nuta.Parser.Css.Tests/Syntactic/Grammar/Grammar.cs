using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class Grammar : SyntacticTest
	{
		[TestMethod]
		public void Is_Stylesheet()
		{
			Check(
				true,
				Stylesheet.S,
				@"
					a[href='./'] {text-decoration: underline; opacity: 0.5}
					p[lang] {font-style: italic}
					li p[lang|=fr]:before {content: url(../flag-fr.png);
					vertical-align: middle; margin-right: 0.33em}
				");

			Check(true, Stylesheet.S, "@charset \"UTF-8\"; /* Theme Name: open-app */ html { margin: 0 }");
			Check(true, Stylesheet.S, "@charset 'utf-8'; /* Theme Name: open-app */ html { margin: 0 }");
		}

		[TestMethod]
		public void Is_Import()
		{
			Check(true, Import.S, "@import'abc';");
			Check(false, Import.S, "@ import'abc';");
			Check(true, Import.S, "@import 'abc';");
			Check(true, Import.S, "@import 'abc' ; ");

			Check(true, Import.S, "@import url(abc) screen, print;");
			Check(false, Import.S, "@import url(abc) screen, print;;");
		}

		[TestMethod]
		public void Is_Import_Additional()
		{
			Check(true, Import.S, "@import \"mystyle.css\";");
			Check(true, Import.S, "@import url(\"mystyle.css\");");
			Check(true, Import.S, "@import url(\"fineprint.css\") print;");
			Check(true, Import.S, "@import url(\"bluish.css\") projection, tv;");
		}

		[TestMethod]
		public void Is_Media()
		{
			Check(true, Media.S, "@media{}");
			Check(false, Media.S, "@ media{}");
			Check(true, Media.S, "@media { } ");
			Check(true, Media.S, "@media screen { }");
			Check(true, Media.S, "@media screen {a{}b{}c{}}");
			Check(true, Media.S, "@media screen { a{} b{} c{} }");
			Check(false, Media.S, "@media screen, print { width: 10px; height: 20px }");
			Check(true, Media.S, "@media screen, print { div { width: 10px; height: 20px } }");
			Check(true, Media.S, "@media screen, print { div { width: 10px; height: 20px; } }");
			Check(false, Media.S, "@media screen, print { div { width: 10px; height: 20px; }; }");
		}

		[TestMethod]
		public void Is_Media_Additional()
		{
			Check(true, Media.S, "@media print { body { font-size: 10pt } }");
			Check(true, Media.S, "@media screen { body { font-size: 13px } }");
			Check(true, Media.S, "@media screen, print { body { line-height: 1.2 } }");
		}

		[TestMethod]
		public void Is_Ruleset()
		{
			Check(true, Ruleset.S, "elem {}");
			Check(true, Ruleset.S, "elem { }");
			Check(true, Ruleset.S, "elem { }   ");
			Check(true, Ruleset.S, "elem { ;;; }");

			Check(true, Ruleset.S, "elem{color:red}");
			Check(true, Ruleset.S, "elem{color:red;}");

			Check(true, Ruleset.S, "elem { color: red }");
			Check(true, Ruleset.S, "elem { color: red; }");

			Check(true, Ruleset.S, "elem#id, .class { width: 10px; height: 20px; }");
		}
	}
}
