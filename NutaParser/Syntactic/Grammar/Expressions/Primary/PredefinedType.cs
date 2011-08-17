namespace NutaParser.Syntactic.Grammar
{
	public class PredefinedType : ParseAny
	{
		public static readonly PredefinedType S = new PredefinedType();

		public PredefinedType()
			: base(
				BoolTerminal.S,
				ByteTerminal.S,
				CharTerminal.S,
				DecimalTerminal.S,
				DoubleTerminal.S,
				FloatTerminal.S,
				IntTerminal.S,
				LongTerminal.S,
				ObjectTerminal.S,
				SbyteTerminal.S,
				ShortTerminal.S,
				StringTerminal.S,
				UintTerminal.S,
				UlongTerminal.S,
				UshortTerminal.S)
		{
		}
	}
}
