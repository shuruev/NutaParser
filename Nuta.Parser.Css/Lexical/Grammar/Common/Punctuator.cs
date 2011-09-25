using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Punctuator : SingleCharacterTerminal
	{
		public static readonly Punctuator S = new Punctuator();

		public Punctuator()
			: base(
				'>',
				'{',
				'}',
				'[',
				']',
				'=',
				';',
				':',
				'/',
				'-',
				'+',
				'*',
				')',
				',',
				'.')
		{
		}
	}
}
