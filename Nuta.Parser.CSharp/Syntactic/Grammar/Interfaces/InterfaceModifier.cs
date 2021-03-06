﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InterfaceModifier : ParseAny
	{
		public static readonly InterfaceModifier S = new InterfaceModifier();

		public InterfaceModifier()
			: base(
				NewTerminal.S,
				PublicTerminal.S,
				ProtectedTerminal.S,
				InternalTerminal.S,
				PrivateTerminal.S)
		{
		}
	}
}
