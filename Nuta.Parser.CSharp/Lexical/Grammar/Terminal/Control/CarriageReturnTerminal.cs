﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class CarriageReturnTerminal : SingleCharacterTerminal
	{
		public static readonly CarriageReturnTerminal S = new CarriageReturnTerminal();

		public CarriageReturnTerminal()
			: base('\x000D')
		{
		}
	}
}
