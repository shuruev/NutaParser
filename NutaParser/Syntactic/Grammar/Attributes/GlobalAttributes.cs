namespace NutaParser.Syntactic.Grammar
{
	public class GlobalAttributes : ParseAll
	{
		public static readonly GlobalAttributes S = new GlobalAttributes();

		public GlobalAttributes()
			: base(GlobalAttributeSections.S)
		{
		}
	}
}
