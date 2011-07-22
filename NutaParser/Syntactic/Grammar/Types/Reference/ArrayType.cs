namespace NutaParser.Syntactic.Grammar
{
	public class ArrayType : ParseAll
	{
		public static readonly ArrayType S = new ArrayType();

		public ArrayType()
			: base(
				NonArrayType.S,
				RankSpecifiers.S)
		{
		}
	}
}
