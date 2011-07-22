namespace NutaParser.Syntactic.Grammar
{
	public class NamespaceName : ParseAll
	{
		public static readonly NamespaceName S = new NamespaceName();

		public NamespaceName()
			: base(
				new ParseAny(
					QualifiedAliasMemberXNamespace.S,
					IdentifierTerminal.S),
				new ParseAny(
					new ParseMany(
						new ParseAll(
							PeriodTerminal.S,
							IdentifierTerminal.S)),
					Empty.S))
		{
		}
	}
}
