using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class UsingStatement : ParseAll
	{
		public static readonly UsingStatement S = new UsingStatement();

		public UsingStatement()
			: base(
				UsingTerminal.S,
				LeftRoundBracketTerminal.S,
				ResourceAcquisition.S,
				RightRoundBracketTerminal.S,
				EmbeddedStatement.S)
		{
		}
	}
}
