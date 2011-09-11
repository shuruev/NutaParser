using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class QualifiedIdentifier : ParseMany
	{
		public static readonly QualifiedIdentifier S = new QualifiedIdentifier();

		public QualifiedIdentifier()
			: base(IdentifierTerminal.S, PeriodTerminal.S)
		{
		}
	}
}
