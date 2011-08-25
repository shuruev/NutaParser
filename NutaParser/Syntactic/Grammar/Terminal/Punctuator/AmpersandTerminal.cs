namespace NutaParser.Syntactic.Grammar
{
	public class AmpersandTerminal : TextTerminal
	{
		public static readonly AmpersandTerminal S = new AmpersandTerminal();

		public AmpersandTerminal()
			: base("&")
		{
		}
	}
}
