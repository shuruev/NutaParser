namespace NutaParser.Lexical.Grammar
{
	public class RealTypeSuffix : LexicalItem
	{
		public static readonly RealTypeSuffix S = new RealTypeSuffix();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => c == 'F'
					|| c == 'f'
					|| c == 'D'
					|| c == 'd'
					|| c == 'M'
					|| c == 'm');
		}
	}
}
