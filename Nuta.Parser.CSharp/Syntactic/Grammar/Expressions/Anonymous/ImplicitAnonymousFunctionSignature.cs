using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ImplicitAnonymousFunctionSignature : ParseAny
	{
		public static readonly ImplicitAnonymousFunctionSignature S = new ImplicitAnonymousFunctionSignature();

		public ImplicitAnonymousFunctionSignature()
			: base(
				new ParseAll(
					LeftRoundBracketTerminal.S,
					ImplicitAnonymousFunctionParameterList.O,
					RightRoundBracketTerminal.S),
				ImplicitAnonymousFunctionParameter.S)
		{
		}
	}
}
