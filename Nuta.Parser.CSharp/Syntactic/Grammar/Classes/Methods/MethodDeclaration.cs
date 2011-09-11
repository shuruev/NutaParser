using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class MethodDeclaration : ParseAll
	{
		public static readonly MethodDeclaration S = new MethodDeclaration();

		public MethodDeclaration()
			: base(
				MethodHeader.S,
				MethodBody.S)
		{
		}
	}
}
