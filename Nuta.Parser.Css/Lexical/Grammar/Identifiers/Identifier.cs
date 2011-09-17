using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Identifier : ParseAll
	{
		public static readonly Identifier S = new Identifier();

		public Identifier()
			: base(
				HyphenTerminal.O,
				NameStart.S,
				Name.O)
		{
		}
	}
}
