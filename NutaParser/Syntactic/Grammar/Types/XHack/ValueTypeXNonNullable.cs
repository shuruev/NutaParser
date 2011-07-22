namespace NutaParser.Syntactic.Grammar
{
	public class ValueTypeXNonNullable : ParseAny
	{
		public static readonly ValueTypeXNonNullable S = new ValueTypeXNonNullable();

		public ValueTypeXNonNullable()
			: base(
				StructTypeXNonNullable.S,
				EnumType.S)
		{
		}
	}
}
