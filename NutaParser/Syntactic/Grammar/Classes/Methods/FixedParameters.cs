using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class FixedParameters : ParseMany
	{
		public static readonly FixedParameters S = new FixedParameters();

		public FixedParameters()
			: base(FixedParameter.S, CommaTerminal.S)
		{
		}
	}
}
