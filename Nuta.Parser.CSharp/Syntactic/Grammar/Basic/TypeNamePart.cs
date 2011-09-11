using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
