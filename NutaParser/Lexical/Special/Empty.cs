namespace NutaParser.Lexical
{
	/// <summary>
	/// Empty lexical item.
	/// </summary>
	public class Empty : LexicalItem
	{
		public static readonly Empty S = new Empty();

		/// <summary>
		/// Tries to parse an entity from the specified lexical machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(LexicalState state)
		{
			return true;
		}
	}
}
