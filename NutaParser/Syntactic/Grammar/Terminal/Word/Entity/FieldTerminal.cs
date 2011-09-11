using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class FieldTerminal : TextTerminal
	{
		public static readonly FieldTerminal S = new FieldTerminal();

		public FieldTerminal()
			: base("field")
		{
		}
	}
}
