namespace NutaParser.Syntactic.Grammar
{
	public class TypeName : ParseAll
	{
		public static readonly TypeName S = new TypeName();

		public TypeName()
			: base(
				new ParseAny(
					QualifiedAliasMember.S,
					new ParseAll(
						IdentifierTerminal.S,
						TypeArgumentList.O)),
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
