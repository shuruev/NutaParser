namespace NutaParser.Syntactic.Grammar
{
	public class TypeofTerminal : TextTerminal
	{
		public static readonly TypeofTerminal S = new TypeofTerminal();

		public TypeofTerminal()
			: base("typeof")
		{
		}
	}
}
