using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class NamedArgumentList : ParseMany
	{
		public static readonly NamedArgumentList S = new NamedArgumentList();

		public NamedArgumentList()
			: base(NamedArgument.S, CommaTerminal.S)
		{
		}
	}
}
