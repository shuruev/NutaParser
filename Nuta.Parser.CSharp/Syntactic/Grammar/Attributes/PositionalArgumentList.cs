using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PositionalArgumentList : ParseMany
	{
		public static readonly PositionalArgumentList S = new PositionalArgumentList();
		public static readonly Optional O = new Optional(S);

		public PositionalArgumentList()
			: base(PositionalArgument.S, CommaTerminal.S)
		{
		}
	}
}
