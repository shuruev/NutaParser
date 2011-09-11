using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class QualifiedAliasMember : ParseAll
	{
		public static readonly QualifiedAliasMember S = new QualifiedAliasMember();

		public QualifiedAliasMember()
			: base(
				IdentifierTerminal.S,
				DoubleColonTerminal.S,
				IdentifierTerminal.S,
				TypeArgumentList.O)
		{
		}
	}
}
