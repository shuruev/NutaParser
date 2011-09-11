using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class ExponentPart : ParseAll
	{
		public static readonly ExponentPart S = new ExponentPart();
		public static readonly Optional O = new Optional(S);

		public ExponentPart()
			: base(
				new SingleCharacterTerminal('e', 'E'),
				Sign.O,
				DecimalDigits.S)
		{
		}
	}
}
