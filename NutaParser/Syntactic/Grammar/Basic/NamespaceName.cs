namespace NutaParser.Syntactic.Grammar
{
	public class NamespaceName : ParseAll
	{
		public static readonly NamespaceName S = new NamespaceName();

		public NamespaceName()
			: base(
				QualifiedAliasPrefix.O,
				new ParseMany(NamespaceNamePart.S, PeriodTerminal.S))
		{
		}
	}
}
