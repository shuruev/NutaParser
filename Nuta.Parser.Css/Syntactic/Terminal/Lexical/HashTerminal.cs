using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class HashTerminal : LexicalTerminal
	{
		public static readonly HashTerminal S = new HashTerminal();

		public HashTerminal()
			: base(Hash.S)
		{
		}
	}
}
