using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class StructInterfaces : ParseAll
	{
		public static readonly StructInterfaces S = new StructInterfaces();
		public static readonly Optional O = new Optional(S);

		public StructInterfaces()
			: base(
				ColonTerminal.S,
				InterfaceTypeList.S)
		{
		}
	}
}
