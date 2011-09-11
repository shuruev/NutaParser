using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class DelimitedCommentSection : ParseAny
	{
		public static readonly DelimitedCommentSection S = new DelimitedCommentSection();

		public DelimitedCommentSection()
			: base(
				new ParseAll(Asterisks.O, NotSlashOrAsterisk.S),
				SlashTerminal.S)
		{
		}
	}
}
