namespace NutaParser.Syntactic.Grammar
{
	public class AccessorModifier : ParseAny
	{
		public static readonly AccessorModifier S = new AccessorModifier();
		public static readonly Optional O = new Optional(S);

		public AccessorModifier()
			: base(
				ProtectedTerminal.S,
				InternalTerminal.S,
				PrivateTerminal.S,
				new ParseAll(ProtectedTerminal.S, InternalTerminal.S),
				new ParseAll(InternalTerminal.S, ProtectedTerminal.S))
		{
		}
	}
}
