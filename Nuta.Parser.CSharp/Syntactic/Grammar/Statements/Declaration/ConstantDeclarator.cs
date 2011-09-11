using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ConstantDeclarator : ParseAll
	{
		public static readonly ConstantDeclarator S = new ConstantDeclarator();

		public ConstantDeclarator()
			: base(
				IdentifierTerminal.S,
				EqualTerminal.S,
				ConstantExpression.S)
		{
		}
	}
}
