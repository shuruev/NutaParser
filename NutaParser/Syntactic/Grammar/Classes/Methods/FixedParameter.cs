namespace NutaParser.Syntactic.Grammar
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
