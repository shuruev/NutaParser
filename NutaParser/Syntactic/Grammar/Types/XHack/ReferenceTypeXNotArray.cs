namespace NutaParser.Syntactic.Grammar
{
	public class ReferenceTypeXNotArray : ParseAny
	{
		public static readonly ReferenceTypeXNotArray S = new ReferenceTypeXNotArray();

		public ReferenceTypeXNotArray()
			: base(
				ClassType.S,
				InterfaceType.S,
				DelegateType.S)
		{
		}
	}
}
