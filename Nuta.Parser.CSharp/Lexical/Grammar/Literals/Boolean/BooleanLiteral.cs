using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class BooleanLiteral : ParseAny
	{
		public static readonly BooleanLiteral S = new BooleanLiteral();

		public BooleanLiteral()
			: base(TrueTerminal.S, FalseTerminal.S)
		{
		}
	}
}
