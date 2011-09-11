using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class IntegerTypeSuffix : ParseAny
	{
		public static readonly IntegerTypeSuffix S = new IntegerTypeSuffix();
		public static readonly Optional O = new Optional(S);

		public IntegerTypeSuffix()
			: base(
				new ParseAll(new SingleCharacterTerminal('U', 'u'), new SingleCharacterTerminal('L', 'l')),
				new ParseAll(new SingleCharacterTerminal('L', 'l'), new SingleCharacterTerminal('U', 'u')),
				new SingleCharacterTerminal('U', 'u', 'L', 'l'))
		{
		}
	}
}
