using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class RankSpecifier : ParseAll
	{
		public static readonly RankSpecifier S = new RankSpecifier();

		public RankSpecifier()
			: base(
				LeftSquareBracketTerminal.S,
				DimSeparators.O,
				RightSquareBracketTerminal.S)
		{
		}
	}
}
