using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class TypeSelector : ParseAll
	{
		public static readonly TypeSelector S = new TypeSelector();

		public TypeSelector()
			: base(
				NamespacePrefix.O,
				ElementName.S)
		{
		}
	}
}
