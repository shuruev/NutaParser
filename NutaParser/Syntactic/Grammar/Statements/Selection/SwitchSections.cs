using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SwitchSections : ParseMany
	{
		public static readonly SwitchSections S = new SwitchSections();
		public static readonly Optional O = new Optional(S);

		public SwitchSections()
			: base(SwitchSection.S)
		{
		}
	}
}
