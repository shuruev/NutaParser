namespace NutaParser.Syntactic.Grammar
{
	public class StructType : ParseAny
	{
		public static readonly StructType S = new StructType();

		public StructType()
			: base(
				TypeName.S,
				SimpleType.S)
		{
		}
	}
}
