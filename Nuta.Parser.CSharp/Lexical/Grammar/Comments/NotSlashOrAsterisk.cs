using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class NotSlashOrAsterisk : ParseExcept
	{
		public static readonly NotSlashOrAsterisk S = new NotSlashOrAsterisk();

		public NotSlashOrAsterisk()
			: base(
				AnyCharacterTerminal.S,
				new ParseAny(SlashTerminal.S, AsteriskTerminal.S))
		{
		}
	}
}
