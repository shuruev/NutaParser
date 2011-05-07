namespace NutaParser.Lexical.Grammar
{
	public class Asterisks : LexicalItem
	{
		public static readonly Asterisks S = new Asterisks();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, AsteriskTerminal.S);
		}
	}
}
