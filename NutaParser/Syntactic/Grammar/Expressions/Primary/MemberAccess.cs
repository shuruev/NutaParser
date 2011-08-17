namespace NutaParser.Syntactic.Grammar
{
	public class MemberAccess : ParseAny
	{
		public static readonly MemberAccess S = new MemberAccess();

		public MemberAccess()
			: base(
				/*xxxnew ParseAll(PrimaryExpression.S, PeriodTerminal.S, IdentifierTerminal.S, TypeArgumentList.O),*/
				new ParseAll(PredefinedType.S, PeriodTerminal.S, IdentifierTerminal.S, TypeArgumentList.O),
				new ParseAll(QualifiedAliasMember.S, PeriodTerminal.S, IdentifierTerminal.S))
		{
		}
	}
}
