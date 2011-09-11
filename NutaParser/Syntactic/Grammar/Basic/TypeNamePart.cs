using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class TypeNamePart : ParseAll
	{
		public static readonly TypeNamePart S = new TypeNamePart();

		public TypeNamePart()
			: base(
				IdentifierTerminal.S,
				TypeArgumentList.O)
		{
		}
	}
}
