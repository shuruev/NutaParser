namespace NutaParser.Syntactic
{
	/// <summary>
	/// Empty syntactic item.
	/// </summary>
	public class Empty : SyntacticItem
	{
		public static readonly Empty S = new Empty();

		/// <summary>
		/// Tries to parse an entity from the specified syntactic machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public override bool Parse(SyntacticState state)
		{
			return true;
		}
	}
}
