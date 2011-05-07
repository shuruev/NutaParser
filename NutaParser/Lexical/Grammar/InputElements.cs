namespace NutaParser.Lexical.Grammar
{
	public class InputElements : LexicalItem
	{
		public static readonly InputElements S = new InputElements();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, InputElement.S);
		}
	}
}
