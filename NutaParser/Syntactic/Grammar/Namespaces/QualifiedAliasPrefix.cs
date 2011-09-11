using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class QualifiedAliasPrefix : ParseAll
	{
		public static readonly QualifiedAliasPrefix S = new QualifiedAliasPrefix();
		public static readonly Optional O = new Optional(S);

		public QualifiedAliasPrefix()
			: base(
				IdentifierTerminal.S,
				DoubleColonTerminal.S)
		{
		}
	}
}
