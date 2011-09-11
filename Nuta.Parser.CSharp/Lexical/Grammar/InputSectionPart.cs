using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class InputSectionPart : ParseAny
	{
		public static readonly InputSectionPart S = new InputSectionPart();

		public InputSectionPart()
			: base(
				PpDirective.S,
				new ParseAll(InputElements.O, NewLine.S))
		{
		}
	}
}
