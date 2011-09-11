using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class EventModifier : ParseAny
	{
		public static readonly EventModifier S = new EventModifier();

		public EventModifier()
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
