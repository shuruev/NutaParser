namespace NutaParser.Syntactic.Grammar
{
	public class TypeXNotArray : SyntacticItem
	{
		public static readonly TypeXNotArray S = new TypeXNotArray();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				NullableType.S,
				ClassType.S,
				InterfaceType.S,
				DelegateType.S,
				StructType.S,
				EnumType.S,
				TypeParameter.S);
		}
	}
}
