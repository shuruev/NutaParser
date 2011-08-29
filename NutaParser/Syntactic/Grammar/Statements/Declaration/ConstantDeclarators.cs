namespace NutaParser.Syntactic.Grammar
{
	public class ConstantDeclarators : ParseMany
	{
		public static readonly ConstantDeclarators S = new ConstantDeclarators();

		public ConstantDeclarators()
			: base(ConstantDeclarator.S, CommaTerminal.S)
		{
		}
	}
}
