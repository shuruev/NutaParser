using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
