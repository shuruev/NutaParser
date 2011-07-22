namespace NutaParser.Syntactic.Grammar
{
	public class StructTypeXNonNullable : ParseAny
	{
		public static readonly StructTypeXNonNullable S = new StructTypeXNonNullable();

		public StructTypeXNonNullable()
			: base(
				TypeName.S,
				SimpleType.S)
		{
		}
	}
}
