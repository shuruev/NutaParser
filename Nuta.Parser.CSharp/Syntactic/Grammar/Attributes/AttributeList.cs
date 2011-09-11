using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AttributeList : ParseMany
	{
		public static readonly AttributeList S = new AttributeList();

		public AttributeList()
			: base(Attribute.S, CommaTerminal.S)
		{
		}
	}
}
