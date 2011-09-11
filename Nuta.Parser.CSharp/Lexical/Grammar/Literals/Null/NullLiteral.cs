using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class NullLiteral : ParseAll
	{
		public static readonly NullLiteral S = new NullLiteral();

		public NullLiteral()
			: base(NullTerminal.S)
		{
		}
	}
}
