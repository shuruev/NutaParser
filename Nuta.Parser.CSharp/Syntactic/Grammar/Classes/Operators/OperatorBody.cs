using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class OperatorBody : ParseAny
	{
		public static readonly OperatorBody S = new OperatorBody();

		public OperatorBody()
			: base(
				SemicolonTerminal.S,
				Block.S)
		{
		}
	}
}
