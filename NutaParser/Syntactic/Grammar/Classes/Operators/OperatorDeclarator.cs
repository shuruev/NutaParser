using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
