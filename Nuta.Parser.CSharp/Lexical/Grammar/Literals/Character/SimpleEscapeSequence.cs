using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class SimpleEscapeSequence : ParseAll
	{
		public static readonly SimpleEscapeSequence S = new SimpleEscapeSequence();

		public SimpleEscapeSequence()
			: base(
				BackslashTerminal.S,
				new SingleCharacterTerminal('\'', '"', '\\', '0', 'a', 'b', 'f', 'n', 'r', 't', 'v'))
		{
		}
	}
}
