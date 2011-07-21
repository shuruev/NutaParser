namespace NutaParser.Syntactic.Grammar
{
	/*xxx no tests yet */
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
