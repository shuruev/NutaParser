namespace NutaParser.Syntactic.Grammar
{
	public class NonArrayType : ParseAny
	{
		public static readonly NonArrayType S = new NonArrayType();

		public NonArrayType()
			: base(Type.S)
		{
		}
	}
}
