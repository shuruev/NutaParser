using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class TypeTerminal : TextTerminal
	{
		public static readonly TypeTerminal S = new TypeTerminal();

		public TypeTerminal()
			: base("type")
		{
		}
	}
}
