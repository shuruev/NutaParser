using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
