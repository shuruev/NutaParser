namespace NutaParser.Syntactic.Grammar
{
	public class JoinTerminal : TextTerminal
	{
		public static readonly JoinTerminal S = new JoinTerminal();

		public JoinTerminal()
			: base("join")
		{
		}
	}
}
