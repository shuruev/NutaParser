using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class OperatorDeclaration : ParseAll
	{
		public static readonly OperatorDeclaration S = new OperatorDeclaration();

		public OperatorDeclaration()
			: base(
				Attributes.O,
				OperatorModifiers.S,
				OperatorDeclarator.S,
				OperatorBody.S)
		{
		}
	}
}
