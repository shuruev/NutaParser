using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class EventAccessorDeclarations : ParseAny
	{
		public static readonly EventAccessorDeclarations S = new EventAccessorDeclarations();

		public EventAccessorDeclarations()
			: base(
				new ParseAll(AddAccessorDeclaration.S, RemoveAccessorDeclaration.S),
				new ParseAll(RemoveAccessorDeclaration.S, AddAccessorDeclaration.S))
		{
		}
	}
}
