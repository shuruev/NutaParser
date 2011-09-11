using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class TypeParameterConstraintsClauses : ParseMany
	{
		public static readonly TypeParameterConstraintsClauses S = new TypeParameterConstraintsClauses();
		public static readonly Optional O = new Optional(S);

		public TypeParameterConstraintsClauses()
			: base(TypeParameterConstraintsClause.S)
		{
		}
	}
}
