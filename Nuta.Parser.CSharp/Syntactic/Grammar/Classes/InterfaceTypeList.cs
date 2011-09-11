using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InterfaceTypeList : ParseMany
	{
		public static readonly InterfaceTypeList S = new InterfaceTypeList();

		public InterfaceTypeList()
			: base(InterfaceType.S, CommaTerminal.S)
		{
		}
	}
}
