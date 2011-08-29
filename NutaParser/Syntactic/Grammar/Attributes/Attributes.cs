namespace NutaParser.Syntactic.Grammar
{
	public class Attributes : ParseAll
	{
		public static readonly Attributes S = new Attributes();

		public Attributes()
			: base(AttributeSections.S)
		{
		}
	}
}
