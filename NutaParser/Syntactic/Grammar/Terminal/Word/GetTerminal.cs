namespace NutaParser.Syntactic.Grammar
{
	public class GetTerminal : TextTerminal
	{
		public static readonly GetTerminal S = new GetTerminal();

		public GetTerminal()
			: base("get")
		{
		}
	}
}
