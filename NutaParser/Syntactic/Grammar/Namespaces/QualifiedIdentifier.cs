namespace NutaParser.Syntactic.Grammar
{
	public class QualifiedIdentifier : ParseMany
	{
		public static readonly QualifiedIdentifier S = new QualifiedIdentifier();

		public QualifiedIdentifier()
			: base(IdentifierTerminal.S, PeriodTerminal.S)
		{
		}
	}
}
