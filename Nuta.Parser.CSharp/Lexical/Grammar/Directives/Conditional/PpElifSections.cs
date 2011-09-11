using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class PpElifSections : ParseMany
	{
		public static readonly PpElifSections S = new PpElifSections();
		public static readonly Optional O = new Optional(S);

		public PpElifSections()
			: base(PpElifSection.S)
		{
		}
	}
}
