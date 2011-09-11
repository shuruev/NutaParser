using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class LetClause : ParseAll
	{
		public static readonly LetClause S = new LetClause();

		public LetClause()
			: base(
				LetTerminal.S,
				IdentifierTerminal.S,
				EqualTerminal.S,
				Expression.S)
		{
		}
	}
}
