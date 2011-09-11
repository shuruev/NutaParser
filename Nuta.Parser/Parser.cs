using System;
using System.IO;
using System.Text;

namespace Nuta.Parser
{
	/// <summary>
	/// Contains some useful and service methods.
	/// </summary>
	public static class Parser
	{
		/// <summary>
		/// Makes a string suitable for one-line displaying.
		/// </summary>
		public static string ToDisplay(this string text)
		{
			return text
				.Replace("\r", "¶")
				.Replace("\n", "¶")
				.Replace("\t", "→")
				.Replace("\v", "→");
		}

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
	}
}
