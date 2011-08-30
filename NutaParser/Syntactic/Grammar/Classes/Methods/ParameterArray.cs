namespace NutaParser.Syntactic.Grammar
{
	public class ParameterArray : ParseAll
	{
		public static readonly ParameterArray S = new ParameterArray();

		public ParameterArray()
			: base(
				Attributes.O,
				ParamsTerminal.S,
				ArrayType.S,
				IdentifierTerminal.S)
		{
		}
	}
}
