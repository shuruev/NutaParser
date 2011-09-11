using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AnonymousObjectInitializer : ParseAny
	{
		public static readonly AnonymousObjectInitializer S = new AnonymousObjectInitializer();

		public AnonymousObjectInitializer()
			: base(
				new ParseAll(
					LeftCurlyBracketTerminal.S,
					MemberDeclaratorList.O,
					RightCurlyBracketTerminal.S),
				new ParseAll(
					LeftCurlyBracketTerminal.S,
					MemberDeclaratorList.S,
					CommaTerminal.S,
					RightCurlyBracketTerminal.S))
		{
		}
	}
}
