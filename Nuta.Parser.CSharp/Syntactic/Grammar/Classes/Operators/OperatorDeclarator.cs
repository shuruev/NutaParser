using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class OperatorDeclarator : ParseAny
	{
		public static readonly OperatorDeclarator S = new OperatorDeclarator();

		public OperatorDeclarator()
			: base(
				UnaryOperatorDeclarator.S,
				BinaryOperatorDeclarator.S,
				ConversionOperatorDeclarator.S)
		{
		}
	}
}
