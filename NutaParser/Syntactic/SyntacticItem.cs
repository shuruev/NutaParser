namespace NutaParser.Syntactic
{
	/// <summary>
	/// Represents an entity from a syntactic grammar.
	/// </summary>
	public abstract class SyntacticItem
	{
		#region Properties

		/// <summary>
		/// Gets entity key.
		/// </summary>
		public string Key
		{
			get
			{
				return GetType().Name;
			}
		}

		#endregion

		#region Parsing methods

		/// <summary>
		/// Tries to parse an entity from the specified syntactic machine state.
		/// In case of success returns true and advances parsing position.
		/// </summary>
		public abstract bool Parse(SyntacticState state);

		#endregion

		#region Parsing other syntactic items

		/// <summary>
		/// Tries to parse any of specified syntactic items.
		/// </summary>
		public bool ParseAny(SyntacticState state, params SyntacticItem[] parts)
		{
			int innerIndex = state.InnerPosition;
			int outerIndex = state.OuterPosition;

			foreach (SyntacticItem part in parts)
			{
				if (part.Parse(state))
				{
					state.AddBack(Key, innerIndex, outerIndex);
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Tries to parse a consequent number of specified syntactic items.
		/// </summary>
		public bool ParseAll(SyntacticState state, params SyntacticItem[] parts)
		{
			int innerIndex = state.InnerPosition;
			int outerIndex = state.OuterPosition;

			bool parsed = true;
			foreach (SyntacticItem part in parts)
			{
				if (!part.Parse(state))
				{
					parsed = false;
					break;
				}
			}

			if (!parsed)
			{
				state.Reset(innerIndex, outerIndex);
				return false;
			}

			state.AddBack(Key, innerIndex, outerIndex);
			return true;
		}

		/// <summary>
		/// Tries to parse a batch of similar syntactic items with specified delimiter.
		/// </summary>
		public bool ParseMany(SyntacticState state, SyntacticItem part, SyntacticItem delimiter)
		{
			/*xxxint index = state.Position;
			while (true)
			{
				if (!part.Parse(state))
					break;

				if (delimiter == null)
					continue;

				if (!delimiter.Parse(state))
					break;
			}

			if (index == state.Position)
				return false;

			state.AddAbsolute(Key, state.Position);*/
			return true;
		}

		#endregion
	}
}
