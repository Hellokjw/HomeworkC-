﻿
namespace Homework01
{
	partial class Form1
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
			this.btnPrev = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.pbView = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPrev
			// 
			this.btnPrev.Location = new System.Drawing.Point(4, 602);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(125, 37);
			this.btnPrev.TabIndex = 0;
			this.btnPrev.Text = "이전";
			this.btnPrev.UseVisualStyleBackColor = true;
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(135, 602);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(125, 37);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "다음";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// pbView
			// 
			this.pbView.Location = new System.Drawing.Point(4, 6);
			this.pbView.Name = "pbView";
			this.pbView.Size = new System.Drawing.Size(1127, 590);
			this.pbView.TabIndex = 2;
			this.pbView.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1137, 648);
			this.Controls.Add(this.pbView);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrev);
			this.Name = "Form1";
			this.Text = "전국 지하철 노선도";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnPrev;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.PictureBox pbView;
	}
}

