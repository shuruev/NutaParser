using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class GlobalAttributeTarget : ParseAny
	{
		public static readonly GlobalAttributeTarget S = new GlobalAttributeTarget();

		public GlobalAttributeTarget()
			: base(
				AssemblyTerminal.S,
				ModuleTerminal.S)
		{
		}
	}
}
