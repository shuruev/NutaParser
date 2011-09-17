using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Asterisks : ParseMany
	{
		public static readonly Asterisks S = new Asterisks();

		public Asterisks()
			: base(AsteriskTerminal.S)
		{
		}
	}
}
