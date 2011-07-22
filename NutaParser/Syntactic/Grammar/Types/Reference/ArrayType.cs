namespace NutaParser.Syntactic.Grammar
{
	public class ArrayType : ParseAll
	{
		public static readonly ArrayType S = new ArrayType();

		public ArrayType()
			: base(
				/*xxxNonArrayType.S*/Type.S,
				RankSpecifiers.S)
		{
		}
	}
}
