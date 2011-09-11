using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class MemberDeclarator : ParseAny
	{
		public static readonly MemberDeclarator S = new MemberDeclarator();

		public MemberDeclarator()
			: base(
				MemberAccess.S,
				new ParseAll(
					IdentifierTerminal.S,
					EqualTerminal.S,
					Expression.S),
				SimpleName.S)
		{
		}
	}
}
