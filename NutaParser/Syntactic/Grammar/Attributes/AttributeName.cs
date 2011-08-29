namespace NutaParser.Syntactic.Grammar
{
	public class AttributeName : ParseAll
	{
		public static readonly AttributeName S = new AttributeName();

		public AttributeName()
			: base(TypeName.S)
		{
		}
	}
}
