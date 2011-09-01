namespace NutaParser.Syntactic.Grammar
{
	public class MemberName : ParseAny
	{
		public static readonly MemberName S = new MemberName();

		public MemberName()
			: base(
				new ParseAll(
					InterfaceType.S,
					PeriodTerminal.S,
					IdentifierTerminal.S),
				IdentifierTerminal.S)
		{
		}
	}
}
