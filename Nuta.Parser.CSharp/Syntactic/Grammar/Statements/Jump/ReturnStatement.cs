using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ReturnStatement : ParseAll
	{
		public static readonly ReturnStatement S = new ReturnStatement();

		public ReturnStatement()
			: base(
				ReturnTerminal.S,
				Expression.O,
				SemicolonTerminal.S)
		{
		}
	}
}
