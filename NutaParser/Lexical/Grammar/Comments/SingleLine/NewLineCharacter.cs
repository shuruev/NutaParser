namespace NutaParser.Lexical.Grammar
{
	public class NewLineCharacter : LexicalItem
	{
		public static readonly NewLineCharacter S = new NewLineCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, Check);
		}

		public static bool Check(char c)
		{
			return c == 0x000D
				|| c == 0x000A
				|| c == 0x0085
				|| c == 0x2028
				|| c == 0x2029;
		}
	}
}
