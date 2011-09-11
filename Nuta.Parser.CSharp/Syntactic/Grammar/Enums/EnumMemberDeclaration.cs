using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class EnumMemberDeclaration : ParseAll
	{
		public static readonly EnumMemberDeclaration S = new EnumMemberDeclaration();

		public EnumMemberDeclaration()
			: base(
				Attributes.O,
				IdentifierTerminal.S,
				new ParseAny(
					new ParseAll(EqualTerminal.S, ConstantExpression.S),
					Empty.S))
		{
		}
	}
}
