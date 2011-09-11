using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class InitializerValue : ParseAny
	{
		public static readonly InitializerValue S = new InitializerValue();

		public InitializerValue()
			: base(
				Expression.S,
				ObjectOrCollectionInitializer.S)
		{
		}
	}
}
