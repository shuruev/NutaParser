using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
