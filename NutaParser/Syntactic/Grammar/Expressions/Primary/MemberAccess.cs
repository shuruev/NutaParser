namespace NutaParser.Syntactic.Grammar
{
	public class MemberAccess : ParseAny
	{
		public static readonly MemberAccess S = new MemberAccess();

		public MemberAccess()
			: base(
				new ParseAll(QualifiedAliasMember.S, PeriodTerminal.S, IdentifierTerminal.S),
				new ParseAll(PredefinedType.S, PeriodTerminal.S, IdentifierTerminal.S, TypeArgumentList.O),
				new ParseAll(
					PrimaryExpressionSimple.S,
					new ParseMany(
						new ParseAll(
							PrimaryExpressionSuffixesNotMemberAccess.O,
							PrimaryExpressionSuffixMemberAccess.S))))
		{
		}
	}
}
