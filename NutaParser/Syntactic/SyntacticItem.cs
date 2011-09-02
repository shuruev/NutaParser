using System;
using System.Diagnostics;
using System.Linq;

namespace NutaParser.Syntactic
{
	/// <summary>
	/// Represents an entity from a syntactic grammar.
	/// </summary>
	public abstract class SyntacticItem
	{
		//xxx
		private const int c_maxResearchDeep = 10000;

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
		private delegate bool ParseDelegate(SyntacticState state, params SyntacticItem[] args);

		/// <summary>
		/// Execute parsing method checking research deep.
		/// </summary>
		private static bool Parse(ParseDelegate action, SyntacticState state, SyntacticItem[] args)
		{
			state.Deep++;

#if DEBUG
			Debug.WriteLine(String.Empty);
			Debug.WriteLine(state.GetOuterDebug());

			SyntacticItem debugItem = (SyntacticItem)action.Target;
			Debug.WriteLine("[{0}] ({1})", debugItem.Key, state.Deep);

			string debugMethod = action.Method.Name;
			debugMethod = debugMethod
				.Split(
					new[] { "Parse", "Internal", "<", ">" },
					StringSplitOptions.RemoveEmptyEntries)
				.First()
				.ToUpperInvariant();

			Debug.Write(debugMethod);
			Debug.Write(" =");
			foreach (var arg in args.Where(arg => arg != null))
			{
				Debug.Write(" | ");
				Debug.Write(arg.Key);
			}

			Debug.WriteLine(String.Empty);
#endif

			if (state.Deep >= c_maxResearchDeep)
				throw new InvalidOperationException(
					String.Format("Maximum research deep {0} has been reached.", c_maxResearchDeep));

			bool parsed = action.Invoke(state, args);

			state.Deep--;
			return parsed;
		}

		/// <summary>
		/// Tries to parse any of specified syntactic items.
		/// </summary>
		public bool ParseAny(SyntacticState state, params SyntacticItem[] parts)
		{
			return Parse(
				ParseAnyInternal,
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
				ParseAllInternal,
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
				(syntacticState, args) => ParseManyInternal(syntacticState, args[0], args[1]),
				state,
				new[] { part, delimiter });
		}

		/// <summary>
		/// Tries to parse a batch of similar syntactic items with specified delimiter.
		/// </summary>
		private bool ParseManyInternal(SyntacticState state, SyntacticItem part, SyntacticItem delimiter)
		{
			if (!part.Parse(state))
				return false;

			while (true)
			{
				int innerIndex = state.InnerPosition;
				int outerIndex = state.OuterPosition;

				if (delimiter != null)
				{
					if (!delimiter.Parse(state))
						break;
				}

				if (!part.Parse(state))
				{
					state.Reset(innerIndex, outerIndex);
					break;
				}
			}

			state.AddAbsolute(Key, state.InnerPosition, state.OuterPosition);
			return true;
		}

		#endregion
	}
}
