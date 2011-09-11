using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class VariableInitializerList : ParseMany
	{
		public static readonly VariableInitializerList S = new VariableInitializerList();
		public static readonly Optional O = new Optional(S);

		public VariableInitializerList()
			: base(VariableInitializer.S, CommaTerminal.S)
		{
		}
	}
}
