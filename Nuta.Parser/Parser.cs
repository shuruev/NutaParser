using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Nuta.Parser.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser
{
	/// <summary>
	/// Contains some useful and service methods.
	/// </summary>
	public static class Parser
	{
		#region Working with input data

		/// <summary>
		/// Reads data string from a specified file.
		/// Contains some logic for auto-detecting an appropriate encoding.
		/// </summary>
		public static string ReadDataFromFile(string filePath)
		{
			string utf8 = File.ReadAllText(filePath, Encoding.UTF8);
			string cp1251 = File.ReadAllText(filePath, Encoding.GetEncoding(1251));

			string data;
			if (utf8.Length < cp1251.Length)
			{
				data = utf8;
			}
			else if (utf8.Length == cp1251.Length)
			{
				data = cp1251;
			}
			else
			{
				throw new InvalidOperationException("Unkonwn encoding");
			}

			return data;
		}

		/// <summary>
		/// Prepares data string so that it always ended with a line-break.
		/// </summary>
		public static string PrepareEndOfFile(string data)
		{
			data = data.TrimEnd('\x001A');
			if (data.Length > 0)
			{
				char last = data[data.Length - 1];
				if (last != '\x000D'
					&& last != '\x000A'
					&& last != '\x2028'
					&& last != '\x2029')
				{
					data = data + '\x000D';
				}
			}

			return data;
		}

		#endregion

		#region Parsing extensions

		/// <summary>
		/// Returns true only if all input data has been successfully parsed.
		/// </summary>
		public static bool ParseFull(this LexicalItem item, LexicalState state)
		{
			bool parsed = item.Parse(state);

			if (!parsed)
				return false;

			if (!state.IsEndOfData)
				return false;

			return true;
		}

		/// <summary>
		/// Returns true only if all input data has been successfully parsed.
		/// </summary>
		public static bool ParseFull(this SyntacticItem item, SyntacticState state)
		{
			bool parsed = item.Parse(state);

			if (!parsed)
				return false;

			if (!state.IsEndOfData)
				return false;

			return true;
		}

		#endregion

		#region Extracting tokens

		/// <summary>
		/// Filters out all entries that are part of another ones.
		/// </summary>
		public static List<LexicalEntry> FilterInclusive(this IEnumerable<LexicalEntry> entries)
		{
			var result = new List<LexicalEntry>();
			int position = 0;

			var input = entries
				.OrderBy(entry => entry.StartPosition)
				.ThenByDescending(entry => entry.Length);

			foreach (var entry in input)
			{
				if (entry.EndPosition <= position)
					continue;

				position = entry.EndPosition;
				result.Add(entry);
			}

			return result;
		}

		#endregion

		#region Service methods

		/// <summary>
		/// Makes a string suitable for one-line displaying.
		/// </summary>
		public static string ToDisplay(this string text)
		{
			return text
				.Substring(0, Math.Min(text.Length, 200))
				.Replace("\r", "¶")
				.Replace("\n", "¶")
				.Replace("\t", "→")
				.Replace("\v", "→");
		}

		#endregion
	}
}
