namespace NutaParser.Syntactic.Grammar
{
	public class GlobalAttributeSections : ParseMany
	{
		public static readonly GlobalAttributeSections S = new GlobalAttributeSections();

		public GlobalAttributeSections()
			: base(GlobalAttributeSection.S)
		{
		}
	}
}
