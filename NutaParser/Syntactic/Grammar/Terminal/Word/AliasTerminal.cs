namespace NutaParser.Syntactic.Grammar
{
	public class AliasTerminal : TextTerminal
	{
		public static readonly AliasTerminal S = new AliasTerminal();

		public AliasTerminal()
			: base("alias")
		{
		}
	}
}
