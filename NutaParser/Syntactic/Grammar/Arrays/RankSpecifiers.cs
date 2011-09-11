using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class RankSpecifiers : ParseMany
	{
		public static readonly RankSpecifiers S = new RankSpecifiers();
		public static readonly Optional O = new Optional(S);

		public RankSpecifiers()
			: base(RankSpecifier.S)
		{
		}
	}
}
