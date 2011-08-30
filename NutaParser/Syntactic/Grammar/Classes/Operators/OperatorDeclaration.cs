namespace NutaParser.Syntactic.Grammar
{
	public class OperatorDeclaration : ParseAll
	{
		public static readonly OperatorDeclaration S = new OperatorDeclaration();

		public OperatorDeclaration()
			: base(
				Attributes.O,
				OperatorModifiers.S,
				OperatorDeclarator.S,
				OperatorBody.S)
		{
		}
	}
}
