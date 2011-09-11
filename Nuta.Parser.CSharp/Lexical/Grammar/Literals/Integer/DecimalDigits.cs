﻿using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class DecimalDigits : ParseMany
	{
		public static readonly DecimalDigits S = new DecimalDigits();

		public DecimalDigits()
			: base(DecimalDigit.S)
		{
		}
	}
}
