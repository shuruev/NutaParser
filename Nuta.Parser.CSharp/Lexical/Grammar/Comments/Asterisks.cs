using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class Asterisks : ParseMany
	{
		public static readonly Asterisks S = new Asterisks();
		public static readonly Optional O = new Optional(S);

		public Asterisks()
			: base(AsteriskTerminal.S)
		{
		}
	}
}
