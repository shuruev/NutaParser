namespace NutaParser.Syntactic.Grammar
{
	public class VirtualTerminal : TextTerminal
	{
		public static readonly VirtualTerminal S = new VirtualTerminal();

		public VirtualTerminal()
			: base("virtual")
		{
		}
	}
}
