using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class MethodModifier : ParseAny
	{
		public static readonly MethodModifier S = new MethodModifier();

		public MethodModifier()
			: base(
				NewTerminal.S,
				PublicTerminal.S,
				ProtectedTerminal.S,
				InternalTerminal.S,
				PrivateTerminal.S,
				StaticTerminal.S,
				VirtualTerminal.S,
				SealedTerminal.S,
				OverrideTerminal.S,
				AbstractTerminal.S,
				ExternTerminal.S)
		{
		}
	}
}
