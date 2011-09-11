using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class VariableDeclarators : ParseMany
	{
		public static readonly VariableDeclarators S = new VariableDeclarators();

		public VariableDeclarators()
			: base(VariableDeclarator.S, CommaTerminal.S)
		{
		}
	}
}
