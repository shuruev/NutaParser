using System;
using System.Collections.Generic;
using NutaParser.Lexical;

namespace NutaParser.Syntactic
{
	/// <summary>
	/// Represents a state of the syntactic machine.
	/// </summary>
	public class SyntacticState
	{
		private readonly Dictionary<int, List<SyntacticEntry>> m_entriesByIndex;

		private readonly List<LexicalEntry> m_data;
		private int m_innerPosition;
		private int m_outerPosition;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public SyntacticState(IEnumerable<LexicalEntry> data)
		{
			if (data == null)
				throw new ArgumentNullException("data");

			m_entriesByIndex = new Dictionary<int, List<SyntacticEntry>>();

			m_data = new List<LexicalEntry>(data);
			m_innerPosition = 0;
			m_outerPosition = 0;
		}

		#region Properties

		/// <summary>
		/// Gets current parsing position relative to lexical terms.
		/// </summary>
		public int InnerPosition
		{
			get
			{
				return m_innerPosition;
			}
		}

		/// <summary>
		/// Gets current parsing position relative to raw input data.
		/// </summary>
		public int OuterPosition
		{
			get
			{
				return m_outerPosition;
			}
		}

		/// <summary>
		/// Gets input data length.
		/// </summary>
		public int Length
		{
			get
			{
				return m_data.Count;
			}
		}

		/// <summary>
		/// Gets a value indicating whether parsing position is at the end of the input data.
		/// </summary>
		public bool IsEndOfData
		{
			get
			{
				return InnerPosition >= Length;
			}
		}

		#endregion

		#region Reading input data

		/// <summary>
		/// Gets input entry at specified position.
		/// </summary>
		public LexicalEntry Get(int innerIndex)
		{
			return m_data[innerIndex];
		}

		#endregion

		#region State machine methods

		/// <summary>
		/// Adds syntactic entry to the parsed entities.
		/// </summary>
		private void Add(SyntacticEntry entry, int innerPosition)
		{
			if (!m_entriesByIndex.ContainsKey(innerPosition))
				m_entriesByIndex[innerPosition] = new List<SyntacticEntry>();

			m_entriesByIndex[innerPosition].Add(entry);
		}

		/// <summary>
		/// Adds new syntactic item and moves parsing position to the new index.
		/// </summary>
		public void AddAbsolute(string key, int innerEndIndex, int outerEndIndex)
		{
			Add(
				new SyntacticEntry(key, m_outerPosition, outerEndIndex),
				m_innerPosition);

			m_innerPosition = innerEndIndex;
			m_outerPosition = outerEndIndex;
		}

		/// <summary>
		/// Adds new syntactic item and moves parsing position forward
		/// by specified number of characters.
		/// </summary>
		public void AddIncrement(string key, int innerIndexIncrement, int outerIndexIncrement)
		{
			AddAbsolute(
				key,
				m_innerPosition + innerIndexIncrement,
				m_outerPosition + outerIndexIncrement);
		}

		/// <summary>
		/// Adds new syntactic item with specified starting position
		/// which will last to the current parsing position.
		/// </summary>
		public void AddBack(string key, int innerStartIndex, int outerStartIndex)
		{
			Add(
				new SyntacticEntry(key, outerStartIndex, m_outerPosition),
				innerStartIndex);
		}

		/// <summary>
		/// Resets parsing position to the specified index
		/// and removes all parsed entities after it.
		/// </summary>
		public void Reset(int innerIndex, int outerIndex)
		{
			if (m_innerPosition == innerIndex)
				return;

			for (int i = m_innerPosition; i >= innerIndex; i--)
				m_entriesByIndex.Remove(i);

			m_innerPosition = innerIndex;
			m_outerPosition = outerIndex;
		}

		#endregion
	}
}
