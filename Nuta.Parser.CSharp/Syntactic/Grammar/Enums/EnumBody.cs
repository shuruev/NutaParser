using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class EnumBody : ParseAll
	{
		public static readonly EnumBody S = new EnumBody();

		public EnumBody()
			: base(
				LeftCurlyBracketTerminal.S,
				new ParseAny(
					new ParseAll(EnumMemberDeclarations.S, CommaTerminal.S),
					EnumMemberDeclarations.S,
					Empty.S),
				RightCurlyBracketTerminal.S)
		{
		}
	}
}
