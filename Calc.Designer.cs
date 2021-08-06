
namespace Homework03
{
	partial class Calc
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSign = new System.Windows.Forms.Button();
			this.btnMod = new System.Windows.Forms.Button();
			this.btnDot = new System.Windows.Forms.Button();
			this.btnDivide = new System.Windows.Forms.Button();
			this.btnMulti = new System.Windows.Forms.Button();
			this.btnMinus = new System.Windows.Forms.Button();
			this.btnPlus = new System.Windows.Forms.Button();
			this.btnEqual = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.txtCalc = new System.Windows.Forms.TextBox();
			this.btn7 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSign
			// 
			this.btnSign.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnSign.Location = new System.Drawing.Point(288, 229);
			this.btnSign.Name = "btnSign";
			this.btnSign.Size = new System.Drawing.Size(90, 43);
			this.btnSign.TabIndex = 40;
			this.btnSign.Text = "+/-";
			this.btnSign.UseVisualStyleBackColor = true;
			this.btnSign.Click += new System.EventHandler(this.btn부호_Click);
			// 
			// btnMod
			// 
			this.btnMod.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnMod.Location = new System.Drawing.Point(195, 228);
			this.btnMod.Name = "btnMod";
			this.btnMod.Size = new System.Drawing.Size(90, 43);
			this.btnMod.TabIndex = 39;
			this.btnMod.Text = "%";
			this.btnMod.UseVisualStyleBackColor = true;
			this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
			// 
			// btnDot
			// 
			this.btnDot.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnDot.Location = new System.Drawing.Point(102, 184);
			this.btnDot.Name = "btnDot";
			this.btnDot.Size = new System.Drawing.Size(89, 42);
			this.btnDot.TabIndex = 38;
			this.btnDot.Text = ".";
			this.btnDot.UseVisualStyleBackColor = true;
			this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
			// 
			// btnDivide
			// 
			this.btnDivide.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnDivide.Location = new System.Drawing.Point(288, 184);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(90, 43);
			this.btnDivide.TabIndex = 37;
			this.btnDivide.Text = "/";
			this.btnDivide.UseVisualStyleBackColor = true;
			this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
			// 
			// btnMulti
			// 
			this.btnMulti.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnMulti.Location = new System.Drawing.Point(288, 141);
			this.btnMulti.Name = "btnMulti";
			this.btnMulti.Size = new System.Drawing.Size(90, 43);
			this.btnMulti.TabIndex = 36;
			this.btnMulti.Text = "*";
			this.btnMulti.UseVisualStyleBackColor = true;
			this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
			// 
			// btnMinus
			// 
			this.btnMinus.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnMinus.Location = new System.Drawing.Point(288, 98);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(90, 43);
			this.btnMinus.TabIndex = 35;
			this.btnMinus.Text = "-";
			this.btnMinus.UseVisualStyleBackColor = true;
			this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
			// 
			// btnPlus
			// 
			this.btnPlus.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnPlus.Location = new System.Drawing.Point(288, 55);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(90, 43);
			this.btnPlus.TabIndex = 34;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// btnEqual
			// 
			this.btnEqual.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnEqual.Location = new System.Drawing.Point(8, 228);
			this.btnEqual.Name = "btnEqual";
			this.btnEqual.Size = new System.Drawing.Size(183, 43);
			this.btnEqual.TabIndex = 33;
			this.btnEqual.Text = "=";
			this.btnEqual.UseVisualStyleBackColor = true;
			this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnCancel.Location = new System.Drawing.Point(195, 184);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(90, 43);
			this.btnCancel.TabIndex = 32;
			this.btnCancel.Text = "CE";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btn0
			// 
			this.btn0.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn0.Location = new System.Drawing.Point(8, 183);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(90, 43);
			this.btn0.TabIndex = 31;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.btn0_Click);
			// 
			// btn3
			// 
			this.btn3.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn3.Location = new System.Drawing.Point(195, 140);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(90, 43);
			this.btn3.TabIndex = 30;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// btn2
			// 
			this.btn2.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn2.Location = new System.Drawing.Point(102, 140);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(90, 43);
			this.btn2.TabIndex = 29;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// btn1
			// 
			this.btn1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn1.Location = new System.Drawing.Point(8, 140);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(90, 43);
			this.btn1.TabIndex = 28;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// btn6
			// 
			this.btn6.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn6.Location = new System.Drawing.Point(195, 97);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(90, 43);
			this.btn6.TabIndex = 27;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.btn6_Click);
			// 
			// btn5
			// 
			this.btn5.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn5.Location = new System.Drawing.Point(102, 97);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(90, 43);
			this.btn5.TabIndex = 26;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.btn5_Click);
			// 
			// btn4
			// 
			this.btn4.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn4.Location = new System.Drawing.Point(8, 97);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(90, 43);
			this.btn4.TabIndex = 25;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.btn4_Click);
			// 
			// btn9
			// 
			this.btn9.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn9.Location = new System.Drawing.Point(195, 54);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(90, 43);
			this.btn9.TabIndex = 24;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.btn9_Click);
			// 
			// btn8
			// 
			this.btn8.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn8.Location = new System.Drawing.Point(102, 54);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(90, 43);
			this.btn8.TabIndex = 23;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.btn8_Click);
			// 
			// txtCalc
			// 
			this.txtCalc.Location = new System.Drawing.Point(8, 12);
			this.txtCalc.Multiline = true;
			this.txtCalc.Name = "txtCalc";
			this.txtCalc.Size = new System.Drawing.Size(421, 28);
			this.txtCalc.TabIndex = 22;
			this.txtCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btn7
			// 
			this.btn7.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn7.Location = new System.Drawing.Point(8, 54);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(90, 43);
			this.btn7.TabIndex = 21;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.btn7_Click);
			// 
			// Calc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 285);
			this.Controls.Add(this.btnSign);
			this.Controls.Add(this.btnMod);
			this.Controls.Add(this.btnDot);
			this.Controls.Add(this.btnDivide);
			this.Controls.Add(this.btnMulti);
			this.Controls.Add(this.btnMinus);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.btnEqual);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.txtCalc);
			this.Controls.Add(this.btn7);
			this.Name = "Calc";
			this.Text = "미니 계산기(사칙연산)";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSign;
		private System.Windows.Forms.Button btnMod;
		private System.Windows.Forms.Button btnDot;
		private System.Windows.Forms.Button btnDivide;
		private System.Windows.Forms.Button btnMulti;
		private System.Windows.Forms.Button btnMinus;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btnEqual;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		internal System.Windows.Forms.TextBox txtCalc;
		private System.Windows.Forms.Button btn7;
	}
}

