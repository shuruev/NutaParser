namespace NutaParser.Syntactic.Grammar
{
	public class DefaultTerminal : TextTerminal
	{
		public static readonly DefaultTerminal S = new DefaultTerminal();

		public DefaultTerminal()
			: base("default")
		{
		}
	}
}
