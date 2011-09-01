namespace NutaParser.Syntactic.Grammar
{
	public class MemberAccess : ParseAll
	{
		public static readonly MemberAccess S = new MemberAccess();

		public MemberAccess()
			: base(
				PrimaryExpressionSimple.S,
				new ParseMany(
					new ParseAll(
						PrimaryExpressionSuffixesNotMemberAccess.O,
						PrimaryExpressionSuffixMemberAccess.S)))
		{
		}
	}
}
