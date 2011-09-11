using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class Attributes : ParseAll
	{
		public static readonly Attributes S = new Attributes();
		public static readonly Optional O = new Optional(S);

		public Attributes()
			: base(AttributeSections.S)
		{
		}
	}
}
