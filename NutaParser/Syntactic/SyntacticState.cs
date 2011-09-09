using System;
using System.Collections.Generic;
using System.Linq;
using NutaParser.Lexical;

namespace NutaParser.Syntactic
{
	/// <summary>
	/// Represents a state of the syntactic machine.
	/// </summary>
	public class SyntacticState
	{
		private readonly Dictionary<int, List<SyntacticEntry>> m_entriesByIndex;
		private readonly Dictionary<string, Stack<object>> m_stateFlags;

		private readonly List<LexicalEntry> m_innerData;
		private readonly string m_outerData;
		private int m_innerPosition;
		private int m_outerPosition;

		internal int Deep;

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public SyntacticState(IEnumerable<LexicalEntry> innerData, string outerData)
		{
			if (innerData == null)
				throw new ArgumentNullException("innerData");

			if (outerData == null)
				throw new ArgumentNullException("outerData");

			m_entriesByIndex = new Dictionary<int, List<SyntacticEntry>>();
			m_stateFlags = new Dictionary<string, Stack<object>>();

			m_innerData = new List<LexicalEntry>(innerData);
			m_outerData = outerData;
			m_innerPosition = 0;
			m_outerPosition = 0;

			Deep = 0;
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
		/// Gets input data length expressed in lexical terms.
		/// </summary>
		public int InnerLength
		{
			get
			{
				return m_innerData.Count;
			}
		}

		/// <summary>
		/// Gets input data length expressed in outer characters.
		/// </summary>
		public int OuterLength
		{
			get
			{
				return m_outerData.Length;
			}
		}

		/// <summary>
		/// Gets a value indicating whether parsing position is at the end of the input data.
		/// </summary>
		public bool IsEndOfData
		{
			get
			{
				return InnerPosition >= InnerLength;
			}
		}

		#endregion

		#region Reading input data

		/// <summary>
		/// Gets input entry at specified position.
		/// </summary>
		public LexicalEntry GetInner(int innerIndex)
		{
			return m_innerData[innerIndex];
		}

		/// <summary>
		/// Gets input data related to specified entry.
		/// </summary>
		public string GetOuter(LexicalEntry entry)
		{
			return m_outerData.Substring(entry.StartPosition, entry.Length);
		}

		/// <summary>
		/// Gets input data starting from current position.
		/// </summary>
		internal string GetOuterDebug()
		{
			return m_outerData
				.Substring(m_outerPosition, Math.Min(60, m_outerData.Length - m_outerPosition))
				.ToDisplay();
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

		#region Working with result

		/// <summary>
		/// Checks whether there is specified entry at specified position.
		/// </summary>
		public bool CheckEntry(string key, int innerIndex)
		{
			if (!m_entriesByIndex.ContainsKey(innerIndex))
				return false;

			return m_entriesByIndex[innerIndex]
				.Any(item => item.Key == key);
		}

		#endregion

		#region Working with flags

		/// <summary>
		/// Raises a boolean flag with specified key.
		/// </summary>
		public void RaiseFlag(string flagKey)
		{
			SetFlag(flagKey, true);
		}

		/// <summary>
		/// Lowers a boolean flag with specified key.
		/// </summary>
		public void LowerFlag(string flagKey)
		{
			ResetFlag(flagKey);
		}

		/// <summary>
		/// Checks whether a boolean flag with specified key is raised.
		/// </summary>
		public bool CheckFlag(string flagKey)
		{
			return GetFlag<bool>(flagKey);
		}

		/// <summary>
		/// Sets a value for a flag with specified key.
		/// </summary>
		public void SetFlag<T>(string flagKey, T value)
		{
			if (!m_stateFlags.ContainsKey(flagKey))
				m_stateFlags[flagKey] = new Stack<object>();

			m_stateFlags[flagKey].Push(value);
		}

		/// <summary>
		/// Resets a value for a flag with specified key.
		/// </summary>
		public void ResetFlag(string flagKey)
		{
			if (!m_stateFlags.ContainsKey(flagKey))
				throw new InvalidOperationException(
					String.Format("Flag {0} does not exist.", flagKey));

			if (m_stateFlags[flagKey].Count == 0)
				throw new InvalidOperationException(
					String.Format("Flag {0} was not set.", flagKey));

			m_stateFlags[flagKey].Pop();
		}

		/// <summary>
		/// Gets a value for a flag with specified key.
		/// </summary>
		public T GetFlag<T>(string flagKey)
		{
			if (!m_stateFlags.ContainsKey(flagKey))
				return default(T);

			return (T)m_stateFlags[flagKey].Peek();
		}

		#endregion
	}
}
