using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class QualifiedAliasMember : ParseAll
	{
		public static readonly QualifiedAliasMember S = new QualifiedAliasMember();

		public QualifiedAliasMember()
			: base(
				IdentifierTerminal.S,
				DoubleColonTerminal.S,
				IdentifierTerminal.S,
				TypeArgumentList.O)
		{
		}
	}
}
