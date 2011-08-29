namespace NutaParser.Syntactic.Grammar
{
	public class ThrowTerminal : TextTerminal
	{
		public static readonly ThrowTerminal S = new ThrowTerminal();

		public ThrowTerminal()
			: base("throw")
		{
		}
	}
}
