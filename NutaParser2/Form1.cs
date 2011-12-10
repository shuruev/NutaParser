using System;
using System.Drawing;
using System.Windows.Forms;
using Nuta.Parser.Css;
using Nuta.Parser.Css.Syntactic;

namespace NutaParser2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			if (CssParser.TryParse(Stylesheet.S, richTextBox1.Text))
			{
				richTextBox1.SelectionStart = 0;
				richTextBox1.SelectionLength = richTextBox1.Text.Length;
				richTextBox1.SelectionColor = Color.DarkGreen;

				richTextBox1.SelectionStart = 0;
				richTextBox1.SelectionLength = 0;
				return;
			}

			if (!richTextBox1.Text.Contains("}"))
			{
				richTextBox1.SelectionStart = 0;
				richTextBox1.SelectionLength = richTextBox1.Text.Length;
				richTextBox1.SelectionColor = Color.Red;

				richTextBox1.SelectionStart = 0;
				richTextBox1.SelectionLength = 0;
				return;
			}

			string[] parts = richTextBox1.Text.Split('}');
			int take = 0;
			int parsed = 0;
			foreach (string part in parts)
			{
				take = take + part.Length + 1;
				string check = richTextBox1.Text.Substring(0, take);
				if (!CssParser.TryParse(Stylesheet.S, check))
					break;

				parsed = take;
			}

			richTextBox1.SelectionStart = 0;
			richTextBox1.SelectionLength = parsed;
			richTextBox1.SelectionColor = Color.DarkGreen;

			richTextBox1.SelectionStart = parsed;
			richTextBox1.SelectionLength = richTextBox1.Text.Length - parsed;
			richTextBox1.SelectionColor = Color.Red;

			richTextBox1.SelectionStart = 0;
			richTextBox1.SelectionLength = 0;
		}
	}
}
