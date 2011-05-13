namespace NutaParser.Lexical
{
	/// <summary>
	/// Lexical item which is optional.
	/// </summary>
	public class Optional : ParseAny
	{
		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public Optional(LexicalItem item)
			: base(item, Empty.S)
		{
		}
	}
}
