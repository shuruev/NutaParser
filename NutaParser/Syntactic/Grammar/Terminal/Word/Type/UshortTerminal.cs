namespace NutaParser.Syntactic.Grammar
{
	public class UshortTerminal : TextTerminal
	{
		public static readonly UshortTerminal S = new UshortTerminal();

		public UshortTerminal()
			: base("ushort")
		{
		}
	}
}
