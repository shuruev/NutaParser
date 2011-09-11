using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class StaticConstructorBody : ParseAny
	{
		public static readonly StaticConstructorBody S = new StaticConstructorBody();

		public StaticConstructorBody()
			: base(
				SemicolonTerminal.S,
				Block.S)
		{
		}
	}
}
