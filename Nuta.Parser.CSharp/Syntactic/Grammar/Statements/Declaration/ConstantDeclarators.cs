using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
