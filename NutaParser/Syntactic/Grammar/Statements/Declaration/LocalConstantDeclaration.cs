namespace NutaParser.Syntactic.Grammar
{
	public class LocalConstantDeclaration : ParseAll
	{
		public static readonly LocalConstantDeclaration S = new LocalConstantDeclaration();

		public LocalConstantDeclaration()
			: base(
				ConstTerminal.S,
				Type.S,
				ConstantDeclarators.S)
		{
		}
	}
}
