namespace NutaParser.Syntactic.Grammar
{
	public class NullableType : ParseAll
	{
		public static readonly NullableType S = new NullableType();

		public NullableType()
			: base(
				new ParseAny(StructType.S, EnumType.S),
				QuestionTerminal.S)
		{
		}
	}
}
