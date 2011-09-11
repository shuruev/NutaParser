using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class Argument : ParseAll
	{
		public static readonly Argument S = new Argument();

		public Argument()
			: base(
				ArgumentName.O,
				ArgumentValue.S)
		{
		}
	}
}
