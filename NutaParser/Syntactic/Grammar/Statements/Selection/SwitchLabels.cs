using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SwitchLabels : ParseMany
	{
		public static readonly SwitchLabels S = new SwitchLabels();

		public SwitchLabels()
			: base(SwitchLabel.S)
		{
		}
	}
}
