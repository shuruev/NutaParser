using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InterfaceType : ParseAny
	{
		public static readonly InterfaceType S = new InterfaceType();

		public InterfaceType()
			: base(TypeName.S)
		{
		}
	}
}
