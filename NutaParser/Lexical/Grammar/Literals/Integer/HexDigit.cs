namespace NutaParser.Lexical.Grammar
{
	public class HexDigit : LexicalItem
	{
		public static readonly HexDigit S = new HexDigit();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => c == '0'
					|| c == '1'
					|| c == '2'
					|| c == '3'
					|| c == '4'
					|| c == '5'
					|| c == '6'
					|| c == '7'
					|| c == '8'
					|| c == '9'
					|| c == 'A'
					|| c == 'B'
					|| c == 'C'
					|| c == 'D'
					|| c == 'E'
					|| c == 'F'
					|| c == 'a'
					|| c == 'b'
					|| c == 'c'
					|| c == 'd'
					|| c == 'e'
					|| c == 'f');
		}
	}
}
