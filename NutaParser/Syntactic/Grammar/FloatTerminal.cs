namespace NutaParser.Syntactic.Grammar
{
	public class FloatTerminal : LexicalTerminal
	{
		public static readonly FloatTerminal S = new FloatTerminal();

		public FloatTerminal()
			: base("FFF")
		{
		}
	}
}
