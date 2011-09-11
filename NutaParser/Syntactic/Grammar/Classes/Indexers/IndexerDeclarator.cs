using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class IndexerDeclarator : ParseAll
	{
		public static readonly IndexerDeclarator S = new IndexerDeclarator();

		public IndexerDeclarator()
			: base(
				Type.S,
				new ParseAny(
					new ParseAll(InterfaceType.S, PeriodTerminal.S),
					Empty.S),
				ThisTerminal.S,
				LeftSquareBracketTerminal.S,
				FormalParameterList.S,
				RightSquareBracketTerminal.S)
		{
		}
	}
}
