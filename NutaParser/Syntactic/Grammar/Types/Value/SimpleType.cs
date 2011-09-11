using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SimpleType : ParseAny
	{
		public static readonly SimpleType S = new SimpleType();

		public SimpleType()
			: base(
				NumericType.S,
				BoolTerminal.S)
		{
		}
	}
}
