using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ExplicitAnonymousFunctionSignature : ParseAll
	{
		public static readonly ExplicitAnonymousFunctionSignature S = new ExplicitAnonymousFunctionSignature();
		public static readonly Optional O = new Optional(S);

		public ExplicitAnonymousFunctionSignature()
			: base(
				LeftRoundBracketTerminal.S,
				ExplicitAnonymousFunctionParameterList.O,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
