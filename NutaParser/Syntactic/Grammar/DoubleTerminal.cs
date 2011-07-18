namespace NutaParser.Syntactic.Grammar
{
	public class DoubleTerminal : LexicalTerminal
	{
		public static readonly DoubleTerminal S = new DoubleTerminal();

		public DoubleTerminal()
			: base("DDD")
		{
		}
	}
}
