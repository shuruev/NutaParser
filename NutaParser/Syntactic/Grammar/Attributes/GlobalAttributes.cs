using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class GlobalAttributes : ParseAll
	{
		public static readonly GlobalAttributes S = new GlobalAttributes();
		public static readonly Optional O = new Optional(S);

		public GlobalAttributes()
			: base(GlobalAttributeSections.S)
		{
		}
	}
}
