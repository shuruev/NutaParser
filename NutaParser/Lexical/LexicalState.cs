using System;
using System.Collections.Generic;
using System.Linq;

namespace NutaParser.Lexical
{
	/// <summary>
	/// Represents a state of the lexical machine.
	/// </summary>
	public class LexicalState
	{
		private readonly Dictionary<int, List<LexicalEntry>> m_entriesByIndex;

		/// <summary>
		/// Gets parsed data.
		/// </summary>
		public string Data { get; private set; }

		/// <summary>
		/// Gets current parsing position.
		/// </summary>
		public int Position { get; private set; }

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public LexicalState(string data)
		{
			if (data == null)
				throw new ArgumentNullException("data");

			m_entriesByIndex = new Dictionary<int, List<LexicalEntry>>();

			Data = data;
			Position = 0;
		}

		#region Properties

		/// <summary>
		/// Gets a value indicating whether parsing position is at the end of the data string.
		/// </summary>
		public bool IsEndOfData
		{
			get
			{
				return Position >= Data.Length;
			}
		}

		#endregion

		#region State machine methods

		/// <summary>
		/// Adds lexical entry to the parsed entities.
		/// </summary>
		private void Add(LexicalEntry entry)
		{
			if (!m_entriesByIndex.ContainsKey(entry.StartPosition))
				m_entriesByIndex[entry.StartPosition] = new List<LexicalEntry>();

			m_entriesByIndex[entry.StartPosition].Add(entry);
		}

		/// <summary>
		/// Adds new lexical item and moves parsing position to the new index.
		/// </summary>
		public void AddAbsolute(string key, int endIndex)
		{
			Add(new LexicalEntry(key, Position, endIndex));
			Position = endIndex;
		}

		/// <summary>
		/// Adds new lexical item and moves parsing position forward
		/// by specified number of characters.
		/// </summary>
		public void AddIncrement(string key, int indexIncrement)
		{
			AddAbsolute(key, Position + indexIncrement);
		}

		/// <summary>
		/// Adds new lexical item with specified starting position
		/// which will last to the current parsing position.
		/// </summary>
		public void AddBack(string key, int startIndex)
		{
			Add(new LexicalEntry(key, startIndex, Position));
		}

		/// <summary>
		/// Resets parsing position to the specified index
		/// and removes all parsed entities after it.
		/// </summary>
		public void Reset(int index)
		{
			if (Position == index)
				return;

			for (int i = Position; i >= index; i--)
				m_entriesByIndex.Remove(i);

			Position = index;
		}

		/// <summary>
		/// Gets parsed entity of specified key starting with specified position.
		/// </summary>
		public string Get(string key, int index)
		{
			if (!m_entriesByIndex.ContainsKey(index))
				return null;

			var entry = m_entriesByIndex[index]
				.Where(i => i.Key == key)
				.FirstOrDefault();

			return Data.Substring(entry.StartPosition, entry.Length);
		}

		#endregion
	}
}
