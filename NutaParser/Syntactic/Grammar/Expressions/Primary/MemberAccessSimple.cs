namespace NutaParser.Syntactic.Grammar
{
	public class MemberAccessSimple : ParseAny
	{
		public static readonly MemberAccessSimple S = new MemberAccessSimple();

		public MemberAccessSimple()
			: base(
				new ParseAll(QualifiedAliasMember.S, PeriodTerminal.S, IdentifierTerminal.S),
				new ParseAll(PredefinedType.S, PeriodTerminal.S, IdentifierTerminal.S, TypeArgumentList.O))
		{
		}
	}
}
