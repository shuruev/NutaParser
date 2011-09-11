using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
