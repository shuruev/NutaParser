namespace NutaParser.Syntactic.Grammar
{
	public class FormalParameterList : ParseAny
	{
		public static readonly FormalParameterList S = new FormalParameterList();
		public static readonly Optional O = new Optional(S);

		public FormalParameterList()
			: base(
				new ParseAll(
					FixedParameters.S,
					CommaTerminal.S,
					ParameterArray.S),
				FixedParameters.S,
				ParameterArray.S)
		{
		}
	}
}
