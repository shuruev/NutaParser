namespace NutaParser.Syntactic.Grammar
{
	public class ReferenceType : ParseAny
	{
		public static readonly ReferenceType S = new ReferenceType();

		public ReferenceType()
			: base(
				ArrayType.S,
				ClassType.S,
				InterfaceType.S,
				DelegateType.S)
		{
		}
	}
}
