namespace NutaParser.Syntactic.Grammar
{
	public class Type : SyntacticItem
	{
		public static readonly Type S = new Type();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				ArrayType.S,
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
