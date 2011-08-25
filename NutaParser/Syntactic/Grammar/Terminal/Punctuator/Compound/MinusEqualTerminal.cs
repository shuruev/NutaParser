namespace NutaParser.Syntactic.Grammar
{
	public class MinusEqualTerminal : TextTerminal
	{
		public static readonly MinusEqualTerminal S = new MinusEqualTerminal();

		public MinusEqualTerminal()
			: base("-=")
		{
		}
	}
}
