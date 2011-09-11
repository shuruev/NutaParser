using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
