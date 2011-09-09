namespace NutaParser.Syntactic.Grammar
{
	public class InterfaceBase : ParseAll
	{
		public static readonly InterfaceBase S = new InterfaceBase();
		public static readonly Optional O = new Optional(S);

		public InterfaceBase()
			: base(
				ColonTerminal.S,
				InterfaceTypeList.S)
		{
		}
	}
}
