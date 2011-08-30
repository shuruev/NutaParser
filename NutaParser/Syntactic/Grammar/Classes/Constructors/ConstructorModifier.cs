namespace NutaParser.Syntactic.Grammar
{
	public class ConstructorModifier : ParseAny
	{
		public static readonly ConstructorModifier S = new ConstructorModifier();

		public ConstructorModifier()
			: base(
				PublicTerminal.S,
				ProtectedTerminal.S,
				InternalTerminal.S,
				PrivateTerminal.S,
				ExternTerminal.S)
		{
		}
	}
}
