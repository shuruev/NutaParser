using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
