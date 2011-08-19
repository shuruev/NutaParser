namespace NutaParser.Syntactic.Grammar
{
	public class AnonymousObjectCreationExpression : ParseAll
	{
		public static readonly AnonymousObjectCreationExpression S = new AnonymousObjectCreationExpression();

		public AnonymousObjectCreationExpression()
			: base(
				NewTerminal.S,
				AnonymousObjectInitializer.S)
		{
		}
	}
}
