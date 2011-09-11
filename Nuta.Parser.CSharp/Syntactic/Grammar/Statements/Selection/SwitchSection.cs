using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
