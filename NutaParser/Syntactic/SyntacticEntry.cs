﻿namespace NutaParser.Syntactic
{
	/// <summary>
	/// Represents an entry of a syntactic entity.
	/// </summary>
	public class SyntacticEntry
	{
		/// <summary>
		/// Gets a syntactic item key.
		/// </summary>
		public string Key { get; private set; }

		/// <summary>
		/// Gets a start position of the syntactic item.
		/// </summary>
		public int StartPosition { get; private set; }

		/// <summary>
		/// Gets an end position of the syntactic item.
		/// </summary>
		public int EndPosition { get; private set; }

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public SyntacticEntry(string key, int startPosition, int endPosition)
		{
			Key = key;
			StartPosition = startPosition;
			EndPosition = endPosition;
		}

		#region Properties

		/// <summary>
		/// Gets syntactic item length.
		/// </summary>
		public int Length
		{
			get
			{
				return EndPosition - StartPosition;
			}
		}

		#endregion
	}
}
