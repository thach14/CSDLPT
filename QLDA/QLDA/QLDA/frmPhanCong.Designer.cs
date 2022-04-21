
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
            this.grNV = new System.Windows.Forms.GroupBox();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbVaiTro = new System.Windows.Forms.ComboBox();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.grNV.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grNV
            // 
            this.grNV.Controls.Add(this.cbbNhanVien);
            this.grNV.Location = new System.Drawing.Point(14, 15);
            this.grNV.Margin = new System.Windows.Forms.Padding(4);
            this.grNV.Name = "grNV";
            this.grNV.Padding = new System.Windows.Forms.Padding(4);
            this.grNV.Size = new System.Drawing.Size(433, 68);
            this.grNV.TabIndex = 1;
            this.grNV.TabStop = false;
            this.grNV.Text = "Nhân viên";
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(7, 27);
            this.cbbNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(413, 26);
            this.cbbNhanVien.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbVaiTro);
            this.groupBox3.Location = new System.Drawing.Point(14, 89);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(433, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vai trò";
            // 
            // cbbVaiTro
            // 
            this.cbbVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbVaiTro.FormattingEnabled = true;
            this.cbbVaiTro.Location = new System.Drawing.Point(7, 27);
            this.cbbVaiTro.Margin = new System.Windows.Forms.Padding(4);
            this.cbbVaiTro.Name = "cbbVaiTro";
            this.cbbVaiTro.Size = new System.Drawing.Size(413, 26);
            this.cbbVaiTro.TabIndex = 0;
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Location = new System.Drawing.Point(186, 164);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(81, 35);
            this.btnPhanCong.TabIndex = 3;
            this.btnPhanCong.Text = "Tạo";
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 221);
            this.Controls.Add(this.btnPhanCong);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grNV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 260);
            this.Name = "frmPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công";
            this.Load += new System.EventHandler(this.frmPhanCong_Load);
            this.grNV.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox grNV;
		private System.Windows.Forms.ComboBox cbbNhanVien;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cbbVaiTro;
		private System.Windows.Forms.Button btnPhanCong;
	}
}