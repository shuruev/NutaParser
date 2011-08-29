namespace NutaParser.Syntactic.Grammar
{
	public class VarTerminal : TextTerminal
	{
		public static readonly VarTerminal S = new VarTerminal();

		public VarTerminal()
			: base("var")
		{
		}
	}
}
