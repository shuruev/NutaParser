using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class Attribute : ParseAll
	{
		public static readonly Attribute S = new Attribute();

		public Attribute()
			: base(
				AttributeName.S,
				AttributeArguments.O)
		{
		}
	}
}
