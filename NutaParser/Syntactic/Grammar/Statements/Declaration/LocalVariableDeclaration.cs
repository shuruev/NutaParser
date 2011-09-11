using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class LocalVariableDeclaration : ParseAll
	{
		public static readonly LocalVariableDeclaration S = new LocalVariableDeclaration();

		public LocalVariableDeclaration()
			: base(
				LocalVariableType.S,
				LocalVariableDeclarators.S)
		{
		}
	}
}
