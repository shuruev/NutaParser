using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class FieldDeclaration : ParseAll
	{
		public static readonly FieldDeclaration S = new FieldDeclaration();

		public FieldDeclaration()
			: base(
				Attributes.O,
				FieldModifiers.O,
				Type.S,
				VariableDeclarators.S,
				SemicolonTerminal.S)
		{
		}
	}
}
