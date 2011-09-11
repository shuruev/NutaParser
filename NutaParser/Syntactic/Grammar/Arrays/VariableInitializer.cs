using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
