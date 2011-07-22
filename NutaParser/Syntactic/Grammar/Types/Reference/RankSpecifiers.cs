namespace NutaParser.Syntactic.Grammar
{
	public class RankSpecifiers : ParseMany
	{
		public static readonly RankSpecifiers S = new RankSpecifiers();

		public RankSpecifiers()
			: base(RankSpecifier.S)
		{
		}
	}
}
