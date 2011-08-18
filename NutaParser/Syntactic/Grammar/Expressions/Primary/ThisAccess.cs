namespace NutaParser.Syntactic.Grammar
{
	public class ThisAccess : ParseAll
	{
		public static readonly ThisAccess S = new ThisAccess();

		public ThisAccess()
			: base(ThisTerminal.S)
		{
		}
	}
}
