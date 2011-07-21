namespace NutaParser.Syntactic
{
	/// <summary>
	/// Represents an entity from a syntactic grammar.
	/// </summary>
	public abstract class SyntacticItem
	{
		private const int c_maxResearchDeep = 100;

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
		/// Delegate used for parsing methods.
		/// </summary>
		private delegate bool ParseDelegate(SyntacticState state, params object[] args);

		/// <summary>
		/// Execute parsing method checking research deep.
		/// </summary>
		private static bool Parse(ParseDelegate action, SyntacticState state, object[] args)
		{
			state.Deep++;

			bool parsed = false;
			if (state.Deep < c_maxResearchDeep)
			{
				parsed = action.Invoke(state, args);
			}

			state.Deep--;
			return parsed;
		}

		/// <summary>
		/// Tries to parse any of specified syntactic items.
		/// </summary>
		public bool ParseAny(SyntacticState state, params SyntacticItem[] parts)
		{
			return Parse(
				(syntacticState, args) => ParseAnyInternal(syntacticState, parts),
				state,
				parts);
		}

		/// <summary>
		/// Tries to parse any of specified syntactic items.
		/// </summary>
		private bool ParseAnyInternal(SyntacticState state, params SyntacticItem[] parts)
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
			return Parse(
				(syntacticState, args) => ParseAllInternal(syntacticState, parts),
				state,
				parts);
		}

		/// <summary>
		/// Tries to parse a consequent number of specified syntactic items.
		/// </summary>
		private bool ParseAllInternal(SyntacticState state, params SyntacticItem[] parts)
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
			return Parse(
				(syntacticState, args) => ParseManyInternal(syntacticState, part, delimiter),
				state,
				new[] { part, delimiter });
		}

		/// <summary>
		/// Tries to parse a batch of similar syntactic items with specified delimiter.
		/// </summary>
		private bool ParseManyInternal(SyntacticState state, SyntacticItem part, SyntacticItem delimiter)
		{
			int innerIndex = state.InnerPosition;
			while (true)
			{
				if (!part.Parse(state))
					break;

				if (delimiter == null)
					continue;

				if (!delimiter.Parse(state))
					break;
			}

			if (innerIndex == state.InnerPosition)
				return false;

			state.AddAbsolute(Key, state.InnerPosition, state.OuterPosition);
			return true;
		}

		#endregion
	}
}
