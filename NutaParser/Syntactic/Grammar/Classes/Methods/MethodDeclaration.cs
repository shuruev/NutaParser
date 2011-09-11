using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
