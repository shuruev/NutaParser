namespace NutaParser.Syntactic.Grammar
{
	public class NamespaceOrTypeName : ParseAll
	{
		public static readonly NamespaceOrTypeName S = new NamespaceOrTypeName();

		public NamespaceOrTypeName()
			: base(
				new ParseAny(
					new ParseAll(QualifiedAliasMember.S),
					new ParseAll(IdentifierTerminal.S, TypeArgumentList.O)),
				new ParseAny(
					new ParseMany(
						new ParseAll(
							PeriodTerminal.S,
							IdentifierTerminal.S,
							TypeArgumentList.O)),
					Empty.S))
		{
		}
	}
}
