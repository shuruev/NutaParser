using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Syntactic;

namespace Nuta.Parser.Css.Tests.Syntactic
{
	[TestClass]
	public class TestSuites : SyntacticTest
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
	}
}
