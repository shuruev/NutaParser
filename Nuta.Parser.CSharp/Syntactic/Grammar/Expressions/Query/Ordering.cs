using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
