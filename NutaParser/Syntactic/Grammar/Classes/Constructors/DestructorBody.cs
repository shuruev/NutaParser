using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class DestructorBody : ParseAny
	{
		public static readonly DestructorBody S = new DestructorBody();

		public DestructorBody()
			: base(
				SemicolonTerminal.S,
				Block.S)
		{
		}
	}
}
