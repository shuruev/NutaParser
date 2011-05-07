namespace NutaParser.Lexical.Grammar
{
	public class DecimalDigit : LexicalItem
	{
		public static readonly DecimalDigit S = new DecimalDigit();

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
					|| c == '9');
		}
	}
}
