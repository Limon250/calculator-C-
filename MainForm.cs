/*
 * Coded in SharpDevelop.
 * User: Limon
 * Date: 04.08.2020 - 05.08.2020
 * Time: 23:56 - undefined
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Calculator : Form
	{
		public Calculator()
		{
			InitializeComponent();
		}
			
		float a;
		float b;
		int count;
		bool znak = true;
			
		private void Button0Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + 0;
		}
		private void Button1Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + 1;
		}
		private void Label1Click(object sender, EventArgs e)
		{
			
		}
		private void Button2Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + 2;
		}
		private void Button3Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + 3;
		}
		private void Button4Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + 4;
		}
		private void Button5Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + 5;
		}
		private void Button6Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + 6;
		}
		private void Button7Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + 7;
		}
		private void Button8Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + 8;
		}
		private void Button9Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + 9;
		}
		private void Button10Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + ",";
		}
		private void Button11ClicK(object sender, EventArgs e)
		{
			a = float.Parse(textBox2.Text);
			textBox2.Clear();
			count = 2;
			label1.Text = a.ToString() + "-";
			znak = true;
		}
		private void Button12CLick(object sender, EventArgs e)
		{
			a = float.Parse(textBox2.Text);
			textBox2.Clear();
			label1.Text = a.ToString() + "*";
			znak = true;
		}
		private void Button13Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox2.Text);
			textBox2.Clear();
			label1.Text = a.ToString() + "/";
			znak = true;
		}
		private void Button14Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox2.Text);
			textBox2.Clear();
			count = 1;
			label1.Text = a.ToString() + "+";
			znak = true;
		}
		private void Button15Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox2.Text);
			textBox2.Clear();
			count = 5;
			label1.Text = a.ToString() + "√";
			znak = true;
		}
		private void Button16Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox2.Text);
			textBox2.Clear();
			count = 6;
			label1.Text = a.ToString() + "sin";
			znak = true;
		}
		private void Button17Click(object sender, EventArgs e)
		{
			calculate();
			label1.Text = "";
		}
		private void Button18Click(object sender, EventArgs e)
		{
			int lenght = textBox2.Text.Length - 1;
			string text = textBox2.Text;
			textBox2.Clear();
			for (int i = 0; i < lenght; i++)
			{
				textBox2.Text = textBox2.Text + text[i];
			}
		}
		private void Button19Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox2.Text);
			textBox2.Clear();
			count = 7;
			label1.Text = a.ToString() + "cos";
			znak = true;
		}
		private void Button20Click(object sender, EventArgs e)
		{
			textBox2.Text = "";
			label1.Text = "";
		}

		private void calculate()
		{
			switch(count)
			{
				case 1:
					b = a + float.Parse(textBox2.Text);
					textBox2.Text = b.ToString();
					break;
				case 2:
					b = a - float.Parse(textBox2.Text);
					textBox2.Text = b.ToString();
					break;
				case 3:
					b = a * float.Parse(textBox2.Text);
					textBox2.Text = b.ToString();
					break;
				case 4:
					b = a / float.Parse(textBox2.Text);
					textBox2.Text = b.ToString();
					break;
				case 5:
					b = (float)Math.Sqrt(a);
					textBox2.Text = b.ToString();
					break;
				case 6:
					b = (float)Math.Sin(a);
					textBox2.Text = b.ToString();
					break;
				case 7:
					b = (float)Math.Cos(a);
					textBox2.Text = b.ToString();
					break;
				default:
					break;
			}
		}
	}
}
