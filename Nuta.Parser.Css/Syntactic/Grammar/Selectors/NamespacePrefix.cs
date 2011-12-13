using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class NamespacePrefix : ParseAll
	{
		public static readonly NamespacePrefix S = new NamespacePrefix();
		public static readonly Optional O = new Optional(S);

		public NamespacePrefix()
			: base(
				new ParseAny(
					IdentifierTerminal.S,
					AsteriskTerminal.S,
					Empty.S),
				BarTerminal.S)
		{
		}
	}
}
