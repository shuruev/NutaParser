using System;
using System.Collections.Generic;
using System.Linq;

namespace Nuta.Parser.Lexical
{
	/// <summary>
	/// Represents a state of the lexical machine.
	/// </summary>
	public class LexicalState
	{
		private readonly Dictionary<int, List<LexicalEntry>> m_entriesByIndex;

		private readonly string m_data;
		private int m_position;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public LexicalState(string data)
		{
			if (data == null)
				throw new ArgumentNullException("data");

			m_entriesByIndex = new Dictionary<int, List<LexicalEntry>>();

			m_data = data;
			m_position = 0;
		}

		#region Properties

		/// <summary>
		/// Gets current parsing position.
		/// </summary>
		public int Position
		{
			get
			{
				return m_position;
			}
		}

		/// <summary>
		/// Gets input data length.
		/// </summary>
		public int Length
		{
			get
			{
				return m_data.Length;
			}
		}

		/// <summary>
		/// Gets a value indicating whether parsing position is at the end of the input data.
		/// </summary>
		public bool IsEndOfData
		{
			get
			{
				return Position >= Length;
			}
		}

		#endregion

		#region Reading input data

		/// <summary>
		/// Gets input character at specified position.
		/// </summary>
		public char Get(int index)
		{
			return m_data[index];
		}

		/// <summary>
		/// Gets input string of specified length starting from specified position.
		/// </summary>
		public string Get(int startIndex, int length)
		{
			return m_data.Substring(startIndex, length);
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

			return m_data.Substring(entry.StartPosition, entry.Length);
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
			Add(new LexicalEntry(key, m_position, endIndex));
			m_position = endIndex;
		}

		/// <summary>
		/// Adds new lexical item and moves parsing position forward
		/// by specified number of characters.
		/// </summary>
		public void AddIncrement(string key, int indexIncrement)
		{
			AddAbsolute(key, m_position + indexIncrement);
		}

		/// <summary>
		/// Adds new lexical item with specified starting position
		/// which will last to the current parsing position.
		/// </summary>
		public void AddBack(string key, int startIndex)
		{
			Add(new LexicalEntry(key, startIndex, m_position));
		}

		/// <summary>
		/// Resets parsing position to the specified index
		/// and removes all parsed entities after it.
		/// </summary>
		public void Reset(int index)
		{
			if (m_position == index)
				return;

			for (int i = m_position; i >= index; i--)
				m_entriesByIndex.Remove(i);

			m_position = index;
		}

		#endregion

		#region Working with result

		/// <summary>
		/// Gets all entries parsed so far.
		/// </summary>
		public IEnumerable<LexicalEntry> GetAllEntries()
		{
			return m_entriesByIndex.Values.SelectMany(list => list);
		}

		#endregion
	}
}
