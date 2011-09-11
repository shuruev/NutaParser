using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
