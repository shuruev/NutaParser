namespace Nuta.Parser.Lexical
{
	/// <summary>
	/// Parses any Unicode character.
	/// </summary>
	public class AnyCharacterTerminal : LexicalItem
	{
		public static readonly AnyCharacterTerminal S = new AnyCharacterTerminal();

		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, c => true);
		}
	}
}
