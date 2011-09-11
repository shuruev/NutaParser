using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class LocalVariableDeclarators : ParseMany
	{
		public static readonly LocalVariableDeclarators S = new LocalVariableDeclarators();

		public LocalVariableDeclarators()
			: base(LocalVariableDeclarator.S, CommaTerminal.S)
		{
		}
	}
}
