﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class MediaFeature : ParseAll
	{
		public static readonly MediaFeature S = new MediaFeature();

		public MediaFeature()
			: base(IdentifierTerminal.S)
		{
		}
	}
}
