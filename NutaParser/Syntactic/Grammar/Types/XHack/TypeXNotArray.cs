namespace NutaParser.Syntactic.Grammar
{
	public class TypeXNotArray : SyntacticItem
	{
		public static readonly TypeXNotArray S = new TypeXNotArray();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				ValueType.S,
				ReferenceTypeXNotArray.S,
				TypeParameter.S);
		}
	}
}
