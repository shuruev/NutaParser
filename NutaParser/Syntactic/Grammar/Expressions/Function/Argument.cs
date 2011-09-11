using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
