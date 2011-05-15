namespace NutaParser.Lexical.Grammar
{
	public class PpElifSections : ParseMany
	{
		public static readonly PpElifSections S = new PpElifSections();

		public PpElifSections()
			: base(PpElifSection.S)
		{
		}
	}
}
