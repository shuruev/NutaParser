namespace NutaParser.Syntactic.Grammar
{
	public class LockTerminal : TextTerminal
	{
		public static readonly LockTerminal S = new LockTerminal();

		public LockTerminal()
			: base("lock")
		{
		}
	}
}
