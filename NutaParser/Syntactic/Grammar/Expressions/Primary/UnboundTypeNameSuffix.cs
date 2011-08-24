namespace NutaParser.Syntactic.Grammar
{
	public class UnboundTypeNameSuffix : ParseMany
	{
		public static readonly UnboundTypeNameSuffix S = new UnboundTypeNameSuffix();
		public static readonly Optional O = new Optional(S);

		public UnboundTypeNameSuffix()
			: base(
				new ParseAll(
					PeriodTerminal.S,
					IdentifierTerminal.S,
					GenericDimensionSpecifier.O))
		{
		}
	}
}
