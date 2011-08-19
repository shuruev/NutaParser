namespace NutaParser.Syntactic.Grammar
{
	public class MemberDeclaratorList : ParseMany
	{
		public static readonly MemberDeclaratorList S = new MemberDeclaratorList();
		public static readonly Optional O = new Optional(S);

		public MemberDeclaratorList()
			: base(MemberDeclarator.S, CommaTerminal.S)
		{
		}
	}
}
