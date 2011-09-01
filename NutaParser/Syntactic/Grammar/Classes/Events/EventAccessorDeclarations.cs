namespace NutaParser.Syntactic.Grammar
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
