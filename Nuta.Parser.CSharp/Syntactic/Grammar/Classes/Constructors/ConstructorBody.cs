using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ConstructorBody : ParseAny
	{
		public static readonly ConstructorBody S = new ConstructorBody();

		public ConstructorBody()
			: base(
				SemicolonTerminal.S,
				Block.S)
		{
		}
	}
}
