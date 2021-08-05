using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework01
{
	public partial class Form1 : Form
	{
		string[] stringArray = { @"C:\Users\littl\Documents\.NET 프레임워크 과정\C# Programming\homeworks\Homework01\bin\Debug\Image\Seoul.png",
			@"C:\Users\littl\Documents\.NET 프레임워크 과정\C# Programming\homeworks\Homework01\bin\Debug\Image\Incheon.png",
			@"C:\Users\littl\Documents\.NET 프레임워크 과정\C# Programming\homeworks\Homework01\bin\Debug\Image\Busan.png",
			@"C:\Users\littl\Documents\.NET 프레임워크 과정\C# Programming\homeworks\Homework01\bin\Debug\Image\Daegu.png",
			@"C:\Users\littl\Documents\.NET 프레임워크 과정\C# Programming\homeworks\Homework01\bin\Debug\Image\Daejeon.png",
			@"C:\Users\littl\Documents\.NET 프레임워크 과정\C# Programming\homeworks\Homework01\bin\Debug\Image\Gwangju.png" };
		// @: Binary 디렉토리와 같은 경로로 설정
		// 4개의 이미지 배열: 0 ~ 5
		int i = 0;

		public Form1(){
			InitializeComponent();
		}

		private void btnPrev_Click(object sender, EventArgs e){
			if (i < 6)
			{
				i--;
				if (i == -1)
				{
					i = 5;
				}
				this.pbView.Image = Image.FromFile(stringArray[i].ToString());
			}
		}

		private void btnNext_Click(object sender, EventArgs e){
			if (i >= 0)
			{
				i++;
				if (i == 6)
				{
					i = 0;
				}
				this.pbView.Image = Image.FromFile(stringArray[i].ToString());
			}
		}

		private void Form1_Load(object sender, EventArgs e){
			this.pbView.Image = Image.FromFile(stringArray[i].ToString());
		}
	}
}
