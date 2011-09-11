namespace Nuta.Parser.Syntactic
{
	/// <summary>
	/// Syntactic item which is optional.
	/// </summary>
	public class Optional : ParseAny
	{
		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public Optional(SyntacticItem item)
			: base(item, Empty.S)
		{
		}
	}
}
