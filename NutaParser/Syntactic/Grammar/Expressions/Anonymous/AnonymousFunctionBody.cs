namespace NutaParser.Syntactic.Grammar
{
	public class AnonymousFunctionBody : ParseAny
	{
		public static readonly AnonymousFunctionBody S = new AnonymousFunctionBody();

		public AnonymousFunctionBody()
			: base(
				Expression.S,
				Block.S)
		{
		}
	}
}
