using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class IndexerModifiers : ParseMany
	{
		public static readonly IndexerModifiers S = new IndexerModifiers();
		public static readonly Optional O = new Optional(S);

		public IndexerModifiers()
			: base(IndexerModifier.S)
		{
		}
	}
}
