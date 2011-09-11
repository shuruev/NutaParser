using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TypePart : ParseAny
	{
		public static readonly TypePart S = new TypePart();

		public TypePart()
			: base(
				TypeName.S,
				SimpleType.S,
				ObjectTerminal.S,
				DynamicTerminal.S,
				StringTerminal.S)
		{
		}
	}
}
