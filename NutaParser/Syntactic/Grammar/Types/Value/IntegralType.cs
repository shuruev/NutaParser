namespace NutaParser.Syntactic.Grammar
{
	public class IntegralType : ParseAny
	{
		public static readonly IntegralType S = new IntegralType();

		public IntegralType()
			: base(
				SbyteTerminal.S,
				ByteTerminal.S,
				ShortTerminal.S,
				UshortTerminal.S,
				IntTerminal.S,
				UintTerminal.S,
				LongTerminal.S,
				UlongTerminal.S,
				CharTerminal.S)
		{
		}
	}
}
