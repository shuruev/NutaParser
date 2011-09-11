using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SwitchSection : ParseAll
	{
		public static readonly SwitchSection S = new SwitchSection();

		public SwitchSection()
			: base(
				SwitchLabels.S,
				StatementList.S)
		{
		}
	}
}
