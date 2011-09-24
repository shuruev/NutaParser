using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class FunctionPrefixTerminal : LexicalTerminal
	{
		public static readonly FunctionPrefixTerminal S = new FunctionPrefixTerminal();

		public FunctionPrefixTerminal()
			: base(FunctionPrefix.S)
		{
		}
	}
}
