using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class LocalVariableDeclarator : ParseAny
	{
		public static readonly LocalVariableDeclarator S = new LocalVariableDeclarator();

		public LocalVariableDeclarator()
			: base(
				new ParseAll(
					IdentifierTerminal.S,
					EqualTerminal.S,
					LocalVariableInitializer.S),
				IdentifierTerminal.S)
		{
		}
	}
}
