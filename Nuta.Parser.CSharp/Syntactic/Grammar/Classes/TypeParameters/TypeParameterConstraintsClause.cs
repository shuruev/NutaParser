using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TypeParameterConstraintsClause : ParseAll
	{
		public static readonly TypeParameterConstraintsClause S = new TypeParameterConstraintsClause();

		public TypeParameterConstraintsClause()
			: base(
				WhereTerminal.S,
				TypeParameter.S,
				ColonTerminal.S,
				TypeParameterConstraints.S)
		{
		}
	}
}
