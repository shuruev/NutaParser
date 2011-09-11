using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
