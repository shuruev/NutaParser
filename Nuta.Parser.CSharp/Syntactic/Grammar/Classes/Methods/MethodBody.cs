using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class MethodBody : ParseAny
	{
		public static readonly MethodBody S = new MethodBody();

		public MethodBody()
			: base(
				SemicolonTerminal.S,
				Block.S)
		{
		}
	}
}
