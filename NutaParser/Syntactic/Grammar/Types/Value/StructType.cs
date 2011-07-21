namespace NutaParser.Syntactic.Grammar
{
	/*xxx no tests yet */
	public class StructType : ParseAny
	{
		public static readonly StructType S = new StructType();

		public StructType()
			: base(
				/*xxxTypeName.S,*/
				SimpleType.S,
				NullableType.S)
		{
		}
	}
}
