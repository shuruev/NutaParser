using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class UncheckedStatement : ParseAll
	{
		public static readonly UncheckedStatement S = new UncheckedStatement();

		public UncheckedStatement()
			: base(
				UncheckedTerminal.S,
				Block.S)
		{
		}
	}
}
