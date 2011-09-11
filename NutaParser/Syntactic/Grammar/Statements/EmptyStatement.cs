using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class EmptyStatement : ParseAll
	{
		public static readonly EmptyStatement S = new EmptyStatement();

		public EmptyStatement()
			: base(SemicolonTerminal.S)
		{
		}
	}
}
