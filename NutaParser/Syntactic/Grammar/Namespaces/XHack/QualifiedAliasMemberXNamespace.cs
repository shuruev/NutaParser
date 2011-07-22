namespace NutaParser.Syntactic.Grammar
{
	public class QualifiedAliasMemberXNamespace : ParseAll
	{
		public static readonly QualifiedAliasMemberXNamespace S = new QualifiedAliasMemberXNamespace();

		public QualifiedAliasMemberXNamespace()
			: base(
				IdentifierTerminal.S,
				DoubleColonTerminal.S,
				IdentifierTerminal.S)
		{
		}
	}
}
