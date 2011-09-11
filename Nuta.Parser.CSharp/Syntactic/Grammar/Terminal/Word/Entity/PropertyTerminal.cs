using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
