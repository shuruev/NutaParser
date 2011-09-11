using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class PropertyTerminal : TextTerminal
	{
		public static readonly PropertyTerminal S = new PropertyTerminal();

		public PropertyTerminal()
			: base("property")
		{
		}
	}
}
