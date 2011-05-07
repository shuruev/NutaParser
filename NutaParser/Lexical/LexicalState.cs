using System;
using System.Collections.Generic;
using System.Linq;

namespace NutaParser.Lexical
{
	public class LexicalState
	{
		private readonly Dictionary<int, List<Tuple<string, int, int>>> m_itemsByIndex;

		public string Data { get; private set; }
		public int Position { get; private set; }

		public LexicalState(string data)
		{
			if (data == null)
				throw new ArgumentNullException("data");

			m_itemsByIndex = new Dictionary<int, List<Tuple<string, int, int>>>();

			Data = data;
			Position = 0;
		}

		public bool IsEndOfFile
		{
			get
			{
				return Position >= Data.Length;
			}
		}

		private void Add(Tuple<string, int, int> item)
		{
			if (!m_itemsByIndex.ContainsKey(item.Item2))
				m_itemsByIndex[item.Item2] = new List<Tuple<string, int, int>>();

			m_itemsByIndex[item.Item2].Add(item);
		}

		public void AddAbsolute(string key, int endIndex)
		{
			Add(new Tuple<string, int, int>(key, Position, endIndex));
			Position = endIndex;
		}

		public void AddIncrement(string key, int indexIncrement)
		{
			AddAbsolute(key, Position + indexIncrement);
		}

		public void AddBack(string key, int startIndex)
		{
			Add(new Tuple<string, int, int>(key, startIndex, Position));
		}

		public void Reset(int index)
		{
			if (Position == index)
				return;

			for (int i = Position; i >= index; i--)
				m_itemsByIndex.Remove(i);

			Position = index;
		}

		public string Get(string key, int index)
		{
			if (!m_itemsByIndex.ContainsKey(index))
				return null;

			var item = m_itemsByIndex[index]
				.Where(i => i.Item1 == key)
				.FirstOrDefault();

			return Data.Substring(item.Item2, item.Item3 - item.Item2);
		}
	}
}
