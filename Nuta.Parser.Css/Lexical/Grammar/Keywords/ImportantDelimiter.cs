using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class ImportantDelimiter : ParseMany
	{
		public static readonly ImportantDelimiter S = new ImportantDelimiter();
		public static readonly Optional O = new Optional(S);

		public ImportantDelimiter()
			: base(
				new ParseAny(
					Whitespace.S,
					Comment.S))
		{
		}
	}
}
