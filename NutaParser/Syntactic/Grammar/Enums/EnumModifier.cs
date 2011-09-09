namespace NutaParser.Syntactic.Grammar
{
	public class EnumModifier : ParseAny
	{
		public static readonly EnumModifier S = new EnumModifier();

		public EnumModifier()
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
