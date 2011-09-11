using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class Ordering : ParseAll
	{
		public static readonly Ordering S = new Ordering();

		public Ordering()
			: base(
				Expression.S,
				OrderingDirection.O)
		{
		}
	}
}
