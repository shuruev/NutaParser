using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
