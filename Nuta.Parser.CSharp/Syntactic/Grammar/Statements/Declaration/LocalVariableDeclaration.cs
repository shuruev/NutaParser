using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
