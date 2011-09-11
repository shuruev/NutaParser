using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
