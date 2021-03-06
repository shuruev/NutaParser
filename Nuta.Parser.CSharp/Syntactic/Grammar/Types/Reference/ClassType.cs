﻿using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ClassType : ParseAny
	{
		public static readonly ClassType S = new ClassType();

		public ClassType()
			: base(
				TypeName.S,
				ObjectTerminal.S,
				DynamicTerminal.S,
				StringTerminal.S)
		{
		}
	}
}
