namespace NutaParser.Syntactic.Grammar
{
	public class ValueType : ParseAny
	{
		public static readonly ValueType S = new ValueType();

		public ValueType()
			: base(
				StructType.S,
				EnumType.S)
		{
		}
	}
}
