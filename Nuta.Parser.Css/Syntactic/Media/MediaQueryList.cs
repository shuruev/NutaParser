using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class MediaQueryList : ParseAny
	{
		public static readonly MediaQueryList S = new MediaQueryList();

		public MediaQueryList()
			: base(
				new ParseMany(
					new ParseAll(
						WhitespaceTerminal.O,
						MediaQuery.S),
					CommaTerminal.S),
				WhitespaceTerminal.O)
		{
		}
	}
}
