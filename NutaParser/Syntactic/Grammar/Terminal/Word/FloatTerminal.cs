namespace NutaParser.Syntactic.Grammar
{
	public class FloatTerminal : TextTerminal
	{
		public static readonly FloatTerminal S = new FloatTerminal();

		public FloatTerminal()
			: base("float")
		{
		}
	}
}
