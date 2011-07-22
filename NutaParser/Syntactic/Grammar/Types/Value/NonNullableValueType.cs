namespace NutaParser.Syntactic.Grammar
{
	public class NonNullableValueType : ParseAny
	{
		public static readonly NonNullableValueType S = new NonNullableValueType();

		public NonNullableValueType()
			: base(ValueTypeXNonNullable.S)
		{
		}
	}
}
