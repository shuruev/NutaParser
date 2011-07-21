using System;

namespace NutaParser.Lexical
{
	/// <summary>
	/// Represents an entry of a lexical entity.
	/// </summary>
	public class LexicalEntry
	{
		/// <summary>
		/// Gets a lexical item key.
		/// </summary>
		public string Key { get; private set; }

		/// <summary>
		/// Gets a start position of the lexical item.
		/// </summary>
		public int StartPosition { get; private set; }

		/// <summary>
		/// Gets an end position of the lexical item.
		/// </summary>
		public int EndPosition { get; private set; }

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public LexicalEntry(string key, int startPosition, int endPosition)
		{
			Key = key;
			StartPosition = startPosition;
			EndPosition = endPosition;
		}

		#region Properties

		/// <summary>
		/// Gets lexical item length.
		/// </summary>
		public int Length
		{
			get
			{
				return EndPosition - StartPosition;
			}
		}

		#endregion

		#region Service methods

		/// <summary>
		/// Returns a string that represents the current object.
		/// </summary>
		public override string ToString()
		{
			return String.Format(
				"{0} [{1}:{2}]",
				Key,
				StartPosition,
				EndPosition);
		}

		#endregion
	}
}
