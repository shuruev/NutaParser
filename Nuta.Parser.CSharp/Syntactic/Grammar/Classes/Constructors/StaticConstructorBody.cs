using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class StaticConstructorBody : ParseAny
	{
		public static readonly StaticConstructorBody S = new StaticConstructorBody();

		public StaticConstructorBody()
			: base(
				SemicolonTerminal.S,
				Block.S)
		{
		}
	}
}
