using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
