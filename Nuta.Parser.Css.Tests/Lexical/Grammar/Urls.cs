using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Tests.Lexical
{
	[TestClass]
	public class Urls : LexicalTest
	{
		[TestMethod]
		public void Is_Url_Characters()
		{
			Check(false, UrlCharacters.S, String.Empty);
			Check(true, UrlCharacters.S, "!#$%&*+,-./09:;<=>?@AZ[\\]^_`az{|}~");
			Check(false, UrlCharacters.S, "\"");
			Check(false, UrlCharacters.S, "'");
			Check(false, UrlCharacters.S, "(");
			Check(false, UrlCharacters.S, ")");
			Check(true, UrlCharacters.S, "http://www.google.com");
			Check(true, UrlCharacters.S, "http://www.google.com.");
			Check(true, UrlCharacters.S, "поиск.ру");
			Check(true, UrlCharacters.S, "\\28\\29");
		}

		[TestMethod]
		public void Is_Uri_1()
		{
			Check(true, Uri1.S, "url('left.png')");
			Check(true, Uri1.S, "URL( \"left.png\" )");
			Check(true, Uri1.S, "\\75\\72\\6c('left.png')");
			Check(true, Uri1.S, "url( '' )");
			Check(true, Uri1.S, "url('')");
			Check(false, Uri1.S, "url(   )");
			Check(false, Uri1.S, "url()");
			Check(false, Uri1.S, "url");
			Check(false, Uri1.S, "url ('left.png')");
		}

		[TestMethod]
		public void Is_Uri_2()
		{
			Check(true, Uri2.S, "url(left.png)");
			Check(true, Uri2.S, "URL( left.png )");
			Check(true, Uri2.S, "\\75\\72\\6c(left.png)");
			Check(false, Uri2.S, "url( '' )");
			Check(false, Uri2.S, "url('')");
			Check(true, Uri2.S, "url(   )");
			Check(true, Uri2.S, "url()");
			Check(false, Uri2.S, "url");
			Check(false, Uri2.S, "url (left.png)");
		}

		[TestMethod]
		public void Is_Uri_Literal()
		{
			Check(true, UriLiteral.S, "url('left.png')");
			Check(true, UriLiteral.S, "url(left.png)");

			Check(true, UriLiteral.S, "url(test/*test)");
			Check(false, UriLiteral.S, "url(test/* test)");
		}
	}
}
