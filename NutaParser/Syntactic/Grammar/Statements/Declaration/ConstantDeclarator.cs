namespace NutaParser.Syntactic.Grammar
{
	public class ConstantDeclarator : ParseAll
	{
		public static readonly ConstantDeclarator S = new ConstantDeclarator();

		public ConstantDeclarator()
			: base(
				IdentifierTerminal.S,
				EqualTerminal.S,
				ConstantExpression.S)
		{
		}
	}
}
