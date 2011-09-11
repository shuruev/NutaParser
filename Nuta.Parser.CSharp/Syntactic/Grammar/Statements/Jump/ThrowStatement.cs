using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ThrowStatement : ParseAll
	{
		public static readonly ThrowStatement S = new ThrowStatement();

		public ThrowStatement()
			: base(
				ThrowTerminal.S,
				Expression.O,
				SemicolonTerminal.S)
		{
		}
	}
}
