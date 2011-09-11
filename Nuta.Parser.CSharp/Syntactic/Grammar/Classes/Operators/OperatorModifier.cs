using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class OperatorModifier : ParseAny
	{
		public static readonly OperatorModifier S = new OperatorModifier();

		public OperatorModifier()
			: base(
				PublicTerminal.S,
				StaticTerminal.S,
				ExternTerminal.S)
		{
		}
	}
}
