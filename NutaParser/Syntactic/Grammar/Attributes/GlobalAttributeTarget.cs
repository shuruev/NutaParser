namespace NutaParser.Syntactic.Grammar
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
