
namespace QLDA
{
	partial class frmPhanCong
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCong));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
			this.cbbNhanVien = new System.Windows.Forms.GroupBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbbVaiTro = new System.Windows.Forms.ComboBox();
			this.btnPhanCong = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.cbbNhanVien.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbbChiNhanh);
			this.groupBox1.Location = new System.Drawing.Point(14, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(433, 68);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chi Nhánh";
			// 
			// cbbChiNhanh
			// 
			this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbChiNhanh.FormattingEnabled = true;
			this.cbbChiNhanh.Location = new System.Drawing.Point(7, 27);
			this.cbbChiNhanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbbChiNhanh.Name = "cbbChiNhanh";
			this.cbbChiNhanh.Size = new System.Drawing.Size(413, 28);
			this.cbbChiNhanh.TabIndex = 0;
			// 
			// cbbNhanVien
			// 
			this.cbbNhanVien.Controls.Add(this.comboBox2);
			this.cbbNhanVien.Location = new System.Drawing.Point(14, 91);
			this.cbbNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbbNhanVien.Name = "cbbNhanVien";
			this.cbbNhanVien.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbbNhanVien.Size = new System.Drawing.Size(433, 68);
			this.cbbNhanVien.TabIndex = 1;
			this.cbbNhanVien.TabStop = false;
			this.cbbNhanVien.Text = "Nhân viên";
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(7, 27);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(413, 28);
			this.comboBox2.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cbbVaiTro);
			this.groupBox3.Location = new System.Drawing.Point(14, 165);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Size = new System.Drawing.Size(433, 68);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Vai trò";
			// 
			// cbbVaiTro
			// 
			this.cbbVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbVaiTro.FormattingEnabled = true;
			this.cbbVaiTro.Location = new System.Drawing.Point(7, 27);
			this.cbbVaiTro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbbVaiTro.Name = "cbbVaiTro";
			this.cbbVaiTro.Size = new System.Drawing.Size(413, 28);
			this.cbbVaiTro.TabIndex = 0;
			// 
			// btnPhanCong
			// 
			this.btnPhanCong.Location = new System.Drawing.Point(186, 240);
			this.btnPhanCong.Name = "btnPhanCong";
			this.btnPhanCong.Size = new System.Drawing.Size(81, 35);
			this.btnPhanCong.TabIndex = 3;
			this.btnPhanCong.Text = "Tạo";
			this.btnPhanCong.UseVisualStyleBackColor = true;
			// 
			// frmPhanCong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 283);
			this.Controls.Add(this.btnPhanCong);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.cbbNhanVien);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(480, 330);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(480, 330);
			this.Name = "frmPhanCong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phân công";
			this.groupBox1.ResumeLayout(false);
			this.cbbNhanVien.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbbChiNhanh;
		private System.Windows.Forms.GroupBox cbbNhanVien;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cbbVaiTro;
		private System.Windows.Forms.Button btnPhanCong;
	}
}