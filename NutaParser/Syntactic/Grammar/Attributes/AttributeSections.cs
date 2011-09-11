using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AttributeSections : ParseMany
	{
		public static readonly AttributeSections S = new AttributeSections();

		public AttributeSections()
			: base(AttributeSection.S)
		{
		}
	}
}
