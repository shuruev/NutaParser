using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AccessorBody : ParseAny
	{
		public static readonly AccessorBody S = new AccessorBody();

		public AccessorBody()
			: base(
				SemicolonTerminal.S,
				Block.S)
		{
		}
	}
}
