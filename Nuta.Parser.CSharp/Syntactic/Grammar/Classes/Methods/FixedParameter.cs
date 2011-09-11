using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class FixedParameter : ParseAll
	{
		public static readonly FixedParameter S = new FixedParameter();

		public FixedParameter()
			: base(
				Attributes.O,
				ParameterModifier.O,
				Type.S,
				IdentifierTerminal.S,
				DefaultArgument.O)
		{
		}
	}
}
