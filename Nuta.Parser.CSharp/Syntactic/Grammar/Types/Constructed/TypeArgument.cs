using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TypeArgument : ParseAny
	{
		public static readonly TypeArgument S = new TypeArgument();

		public TypeArgument()
			: base(Type.S)
		{
		}
	}
}
