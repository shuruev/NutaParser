namespace NutaParser.Syntactic.Grammar
{
	public class UnboundTypeNameSuffixes : ParseMany
	{
		public static readonly UnboundTypeNameSuffixes S = new UnboundTypeNameSuffixes();
		public static readonly Optional O = new Optional(S);

		public UnboundTypeNameSuffixes()
			: base(
				new ParseAll(
					PeriodTerminal.S,
					IdentifierTerminal.S,
					GenericDimensionSpecifier.O))
		{
		}
	}
}
