namespace _13_CS464_TRANCONGTRI_4181
{
	partial class DangNhap
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
			this.txt_MatKhau = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_DangNhap = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tai khoan:";
			// 
			// txt_TaiKhoan
			// 
			this.txt_TaiKhoan.Location = new System.Drawing.Point(115, 54);
			this.txt_TaiKhoan.Name = "txt_TaiKhoan";
			this.txt_TaiKhoan.Size = new System.Drawing.Size(208, 20);
			this.txt_TaiKhoan.TabIndex = 1;
			// 
			// txt_MatKhau
			// 
			this.txt_MatKhau.Location = new System.Drawing.Point(115, 92);
			this.txt_MatKhau.Name = "txt_MatKhau";
			this.txt_MatKhau.Size = new System.Drawing.Size(208, 20);
			this.txt_MatKhau.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mat khau:";
			// 
			// btn_DangNhap
			// 
			this.btn_DangNhap.Location = new System.Drawing.Point(248, 148);
			this.btn_DangNhap.Name = "btn_DangNhap";
			this.btn_DangNhap.Size = new System.Drawing.Size(75, 23);
			this.btn_DangNhap.TabIndex = 4;
			this.btn_DangNhap.Text = "Dang Nhap";
			this.btn_DangNhap.UseVisualStyleBackColor = true;
			this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
			// 
			// DangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 193);
			this.Controls.Add(this.btn_DangNhap);
			this.Controls.Add(this.txt_MatKhau);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_TaiKhoan);
			this.Controls.Add(this.label1);
			this.Name = "DangNhap";
			this.Text = "DangNhap";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_TaiKhoan;
		private System.Windows.Forms.TextBox txt_MatKhau;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_DangNhap;
	}
}