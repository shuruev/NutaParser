namespace NutaParser.Syntactic.Grammar
{
	public class MinusTerminal : TextTerminal
	{
		public static readonly MinusTerminal S = new MinusTerminal();

		public MinusTerminal()
			: base("-")
		{
		}
	}
}
