namespace NutaParser.Syntactic.Grammar
{
	public class PublicTerminal : TextTerminal
	{
		public static readonly PublicTerminal S = new PublicTerminal();

		public PublicTerminal()
			: base("public")
		{
		}
	}
}
