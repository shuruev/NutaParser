using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class VariableReference : ParseAny
	{
		public static readonly VariableReference S = new VariableReference();

		public VariableReference()
			: base(Expression.S)
		{
		}
	}
}
