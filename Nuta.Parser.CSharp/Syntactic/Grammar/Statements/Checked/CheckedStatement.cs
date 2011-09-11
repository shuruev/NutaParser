using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
