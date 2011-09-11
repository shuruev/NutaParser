using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class CheckedStatement : ParseAll
	{
		public static readonly CheckedStatement S = new CheckedStatement();

		public CheckedStatement()
			: base(
				CheckedTerminal.S,
				Block.S)
		{
		}
	}
}
