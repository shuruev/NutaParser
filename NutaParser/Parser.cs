using System;
using System.IO;
using System.Text;

namespace NutaParser
{
	public static class Parser
	{
		public static string ToDisplay(this string text)
		{
			return text
				.Replace("\r", "¶")
				.Replace("\n", "¶")
				.Replace("\t", "→")
				.Replace("\v", "→");
		}

		public static string ReadFileData(string filePath)
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

			return PrepareEndOfFile(data);
		}

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
