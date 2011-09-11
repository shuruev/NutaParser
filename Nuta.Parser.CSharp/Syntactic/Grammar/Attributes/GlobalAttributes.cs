using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
