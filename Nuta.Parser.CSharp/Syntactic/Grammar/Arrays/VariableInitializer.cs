using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class VariableInitializer : ParseAny
	{
		public static readonly VariableInitializer S = new VariableInitializer();

		public VariableInitializer()
			: base(
				Expression.S,
				ArrayInitializer.S)
		{
		}
	}
}
