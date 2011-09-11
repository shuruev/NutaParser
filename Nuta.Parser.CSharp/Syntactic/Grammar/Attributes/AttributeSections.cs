using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
