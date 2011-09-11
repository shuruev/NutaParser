namespace Nuta.Parser.CSharp.Syntactic
{
	/// <summary>
	/// Contains different flags used while parsing.
	/// </summary>
	public static class StateFlags
	{
		/// <summary>
		/// Used to prohibit using LINQ keyword as identifier inside LINQ expression.
		/// </summary>
		public const string InsideLinq = "InsideLinq";

		/// <summary>
		/// Supresses parsing of nullable types.
		/// </summary>
		public const string IgnoreNullable = "IgnoreNullable";

		/// <summary>
		/// Specifies position after which nullable types should be ignored.
		/// </summary>
		public const string IgnoreNullableAfterPosition = "IgnoreNullableAfterPosition";
	}
}
