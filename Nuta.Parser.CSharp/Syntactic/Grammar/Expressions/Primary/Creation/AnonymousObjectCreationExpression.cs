using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
