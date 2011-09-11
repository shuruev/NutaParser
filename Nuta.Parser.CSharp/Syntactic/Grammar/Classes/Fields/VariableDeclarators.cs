using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
