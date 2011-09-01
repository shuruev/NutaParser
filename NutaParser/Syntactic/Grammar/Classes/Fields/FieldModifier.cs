namespace NutaParser.Syntactic.Grammar
{
	public class FieldModifier : ParseAny
	{
		public static readonly FieldModifier S = new FieldModifier();

		public FieldModifier()
			: base(
				NewTerminal.S,
				PublicTerminal.S,
				ProtectedTerminal.S,
				InternalTerminal.S,
				PrivateTerminal.S,
				StaticTerminal.S,
				ReadonlyTerminal.S,
				VolatileTerminal.S)
		{
		}
	}
}
