using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ClassTerminal : TextTerminal
	{
		public static readonly ClassTerminal S = new ClassTerminal();

		public ClassTerminal()
			: base("class")
		{
		}
	}
}
