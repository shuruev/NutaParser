using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
