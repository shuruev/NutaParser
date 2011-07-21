using System;

namespace NutaParser.Syntactic.Grammar
{
	/*xxx no tests yet */
	public class Type : SyntacticItem
	{
		public static readonly Type S = new Type();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				ValueType.S/*xxx,
				ReferenceType.S,
				TypeParameter.S*/);
		}
	}
}
