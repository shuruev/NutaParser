namespace NutaParser.Syntactic.Grammar
{
	/*xxx no tests yet */
	public class NullableType : ParseAll
	{
		public static readonly NullableType S = new NullableType();

		public NullableType()
			: base(
				NonNullableValueType.S,
				QuestionTerminal.S)
		{
		}
	}
}
