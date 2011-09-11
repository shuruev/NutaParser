using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ObjectOrCollectionInitializer : SyntacticItem
	{
		public static readonly ObjectOrCollectionInitializer S = new ObjectOrCollectionInitializer();
		public static readonly Optional O = new Optional(S);

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				ObjectInitializer.S,
				CollectionInitializer.S);
		}
	}
}
