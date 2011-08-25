namespace NutaParser.Syntactic.Grammar
{
	public class AsTerminal : TextTerminal
	{
		public static readonly AsTerminal S = new AsTerminal();

		public AsTerminal()
			: base("as")
		{
		}
	}
}
