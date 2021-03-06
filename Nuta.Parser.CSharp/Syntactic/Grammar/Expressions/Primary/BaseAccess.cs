﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class BaseAccess : ParseAny
	{
		public static readonly BaseAccess S = new BaseAccess();

		public BaseAccess()
			: base(
				new ParseAll(
					BaseTerminal.S,
					PeriodTerminal.S,
					IdentifierTerminal.S,
					TypeArgumentList.O),
				new ParseAll(
					BaseTerminal.S,
					LeftSquareBracketTerminal.S,
					ArgumentList.S,
					RightSquareBracketTerminal.S))
		{
		}
	}
}
