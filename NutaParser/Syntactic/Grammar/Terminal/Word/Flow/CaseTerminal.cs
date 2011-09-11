using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class CaseTerminal : TextTerminal
	{
		public static readonly CaseTerminal S = new CaseTerminal();

		public CaseTerminal()
			: base("case")
		{
		}
	}
}
