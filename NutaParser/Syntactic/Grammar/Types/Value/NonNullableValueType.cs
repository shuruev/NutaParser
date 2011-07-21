namespace NutaParser.Syntactic.Grammar
{
	/*xxx no tests yet */
	public class NonNullableValueType : ParseAny
	{
		public static readonly NonNullableValueType S = new NonNullableValueType();

		public NonNullableValueType()
			: base(/*xxxType.S*/)
		{
		}
	}
}
