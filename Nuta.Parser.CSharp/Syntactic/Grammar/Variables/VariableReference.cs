using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
