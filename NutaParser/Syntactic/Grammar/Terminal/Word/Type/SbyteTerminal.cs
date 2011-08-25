namespace NutaParser.Syntactic.Grammar
{
	public class SbyteTerminal : TextTerminal
	{
		public static readonly SbyteTerminal S = new SbyteTerminal();

		public SbyteTerminal()
			: base("sbyte")
		{
		}
	}
}
