using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ConstantModifier : ParseAny
	{
		public static readonly ConstantModifier S = new ConstantModifier();

		public ConstantModifier()
			: base(
				NewTerminal.S,
				PublicTerminal.S,
				ProtectedTerminal.S,
				InternalTerminal.S,
				PrivateTerminal.S)
		{
		}
	}
}
