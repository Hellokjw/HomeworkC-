using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework03
{
	public partial class Calc : Form
	{
		private double num1 = 0;
		private double num2 = 0;
		private char Oper;

		public Calc(){  InitializeComponent(); }

		private void Form1_Load(object sender, EventArgs e)
		{  }

		private void btn7_Click(object sender, EventArgs e)
		{
			txtCalc.Text = txtCalc.Text + "7";
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			txtCalc.Text = txtCalc.Text + "8";
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			txtCalc.Text = txtCalc.Text + "9";
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			txtCalc.Text = txtCalc.Text + "4";
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			txtCalc.Text = txtCalc.Text + "5";
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			txtCalc.Text = txtCalc.Text + "6";
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			txtCalc.Text = txtCalc.Text + "1";
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			txtCalc.Text = txtCalc.Text + "2";
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			txtCalc.Text = txtCalc.Text + "3";
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			txtCalc.Text = txtCalc.Text + "0";
		}

		private void btnDot_Click(object sender, EventArgs e)
		{
			txtCalc.Text = txtCalc.Text + ".";
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			txtCalc.Text = " ";
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			num1 = double.Parse(txtCalc.Text);
			txtCalc.Text = txtCalc.Text + '+';  //textBox1에 + 기호가 입력된다.
			Oper = '+';
			txtCalc.Text = "";
		}

		private void btnMinus_Click(object sender, EventArgs e)
		{
			num1 = double.Parse(txtCalc.Text);
			txtCalc.Text = txtCalc.Text + '-';  //textBox1에 - 기호가 입력된다.
			Oper = '-';
			txtCalc.Text = "";
		}

		private void btnMulti_Click(object sender, EventArgs e)
		{
			num1 = double.Parse(txtCalc.Text);
			txtCalc.Text = txtCalc.Text + '*';  
			Oper = '*';
			txtCalc.Text = "";
		}

		private void btnDivide_Click(object sender, EventArgs e)
		{
			num1 = double.Parse(txtCalc.Text);
			txtCalc.Text = txtCalc.Text + '/'; 
			Oper = '/';
			txtCalc.Text = "";
		}

		private void btnMod_Click(object sender, EventArgs e)
		{
			num1 = double.Parse(txtCalc.Text);
			txtCalc.Text = txtCalc.Text + '%'; 
			Oper = '%';
			txtCalc.Text = "";
		}

		private void btn부호_Click(object sender, EventArgs e)
		{
			double n1 = Double.Parse(txtCalc.Text);
			txtCalc.Text = (-n1).ToString();
		}

		private void btnEqual_Click(object sender, EventArgs e)
		{
			num2 = double.Parse(txtCalc.Text);
			switch (Oper)
			{
				case '+':                                        //+기호일 경우
					txtCalc.Text = (num1 + num2).ToString();
					break;

				case '-':                                         //-일 경우
					txtCalc.Text = (num1 - num2).ToString();
					break;

				case '*':                                        //*일 경우
					txtCalc.Text = (num1 * num2).ToString();
					break;

				case '/':                                       // /일 경우
					txtCalc.Text = (num1 / num2).ToString();
					break;

				case '%':                                       // %일 경우
					txtCalc.Text = (num1 % num2).ToString();
					break;
			}
		}
	}
}
