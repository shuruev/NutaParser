using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class FunctionPrefix : ParseAll
	{
		public static readonly FunctionPrefix S = new FunctionPrefix();

		public FunctionPrefix()
			: base(
				Identifier.S,
				LeftRoundBracketTerminal.S)
		{
		}
	}
}
