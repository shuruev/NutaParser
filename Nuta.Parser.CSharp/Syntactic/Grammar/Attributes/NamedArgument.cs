using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class NamedArgument : ParseAll
	{
		public static readonly NamedArgument S = new NamedArgument();

		public NamedArgument()
			: base(
				IdentifierTerminal.S,
				EqualTerminal.S,
				AttributeArgumentExpression.S)
		{
		}
	}
}
