using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
