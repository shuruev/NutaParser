using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TypeParameter : ParseAny
	{
		public static readonly TypeParameter S = new TypeParameter();

		public TypeParameter()
			: base(IdentifierTerminal.S)
		{
		}
	}
}
