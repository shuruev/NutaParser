namespace NutaParser.Syntactic.Grammar
{
	/*xxx no tests yet */
	public class EnumType : ParseAny
	{
		public static readonly EnumType S = new EnumType();

		public EnumType()
			: base(/*xxxTypeName.S*/)
		{
		}
	}
}
