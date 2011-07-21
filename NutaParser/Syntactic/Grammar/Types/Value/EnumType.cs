namespace NutaParser.Syntactic.Grammar
{
	public class EnumType : ParseAny
	{
		public static readonly EnumType S = new EnumType();

		public EnumType()
			: base(TypeName.S)
		{
		}
	}
}
