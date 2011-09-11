﻿using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class Keyword : LexicalItem
	{
		public static readonly Keyword S = new Keyword();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(
				state,
				"abstract",
				"as",
				"base",
				"bool",
				"break",
				"byte",
				"case",
				"catch",
				"char",
				"checked",
				"class",
				"const",
				"continue",
				"decimal",
				"default",
				"delegate",
				"double",
				"do",
				"else",
				"enum",
				"event",
				"explicit",
				"extern",
				"false",
				"finally",
				"fixed",
				"float",
				"foreach",
				"for",
				"goto",
				"if",
				"implicit",
				"interface",
				"internal",
				"int",
				"in",
				"is",
				"lock",
				"long",
				"namespace",
				"new",
				"null",
				"object",
				"operator",
				"out",
				"override",
				"params",
				"private",
				"protected",
				"public",
				"readonly",
				"ref",
				"return",
				"sbyte",
				"sealed",
				"short",
				"sizeof",
				"stackalloc",
				"static",
				"string",
				"struct",
				"switch",
				"this",
				"throw",
				"true",
				"try",
				"typeof",
				"uint",
				"ulong",
				"unchecked",
				"unsafe",
				"ushort",
				"using",
				"virtual",
				"void",
				"volatile",
				"while");
		}
	}
}
