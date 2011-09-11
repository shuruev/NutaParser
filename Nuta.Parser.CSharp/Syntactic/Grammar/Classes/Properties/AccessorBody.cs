using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
