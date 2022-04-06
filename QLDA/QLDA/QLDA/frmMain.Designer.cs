
namespace QLDA
{
	partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslChiNhanh = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNhanVien = new System.Windows.Forms.TabPage();
            this.cmsNhanVien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiChuyenCN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSuaNV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoaNV = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tpDuAn = new System.Windows.Forms.TabPage();
            this.cmsDuAn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiChiTietDA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSuaDA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKetThucDA = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemDA = new System.Windows.Forms.Button();
            this.dgvDuAn = new System.Windows.Forms.DataGridView();
            this.tpThongKe = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clbChiNhanh = new System.Windows.Forms.CheckedListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateAcc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpNhanVien.SuspendLayout();
            this.cmsNhanVien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tpDuAn.SuspendLayout();
            this.cmsDuAn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).BeginInit();
            this.tpThongKe.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUser,
            this.tsslChiNhanh,
            this.tsslRole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 647);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1262, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(45, 20);
            this.tsslUser.Text = "User: ";
            // 
            // tsslChiNhanh
            // 
            this.tsslChiNhanh.Name = "tsslChiNhanh";
            this.tsslChiNhanh.Size = new System.Drawing.Size(81, 20);
            this.tsslChiNhanh.Text = "Chi nhánh: ";
            // 
            // tsslRole
            // 
            this.tsslRole.Name = "tsslRole";
            this.tsslRole.Size = new System.Drawing.Size(46, 20);
            this.tsslRole.Text = "Role: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpNhanVien);
            this.tabControl1.Controls.Add(this.tpDuAn);
            this.tabControl1.Controls.Add(this.tpThongKe);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 619);
            this.tabControl1.TabIndex = 1;
            // 
            // tpNhanVien
            // 
            this.tpNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpNhanVien.ContextMenuStrip = this.cmsNhanVien;
            this.tpNhanVien.Controls.Add(this.groupBox1);
            this.tpNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpNhanVien.Location = new System.Drawing.Point(4, 29);
            this.tpNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.tpNhanVien.Name = "tpNhanVien";
            this.tpNhanVien.Padding = new System.Windows.Forms.Padding(4);
            this.tpNhanVien.Size = new System.Drawing.Size(1254, 586);
            this.tpNhanVien.TabIndex = 0;
            this.tpNhanVien.Text = "Nhân viên";
            this.tpNhanVien.UseVisualStyleBackColor = true;
            // 
            // cmsNhanVien
            // 
            this.cmsNhanVien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChuyenCN,
            this.tsmiSuaNV,
            this.tsmiXoaNV});
            this.cmsNhanVien.Name = "cmsNhanVien";
            this.cmsNhanVien.Size = new System.Drawing.Size(211, 104);
            // 
            // tsmiChuyenCN
            // 
            this.tsmiChuyenCN.Name = "tsmiChuyenCN";
            this.tsmiChuyenCN.Size = new System.Drawing.Size(210, 24);
            this.tsmiChuyenCN.Text = "Chuyển Chi Nhánh";
            // 
            // tsmiSuaNV
            // 
            this.tsmiSuaNV.Name = "tsmiSuaNV";
            this.tsmiSuaNV.Size = new System.Drawing.Size(210, 24);
            this.tsmiSuaNV.Text = "Sửa Thông Tin";
            this.tsmiSuaNV.Click += new System.EventHandler(this.tsmiSuaNV_Click);
            // 
            // tsmiXoaNV
            // 
            this.tsmiXoaNV.Name = "tsmiXoaNV";
            this.tsmiXoaNV.Size = new System.Drawing.Size(210, 24);
            this.tsmiXoaNV.Text = "Xoá Nhân Viên";
            this.tsmiXoaNV.Click += new System.EventHandler(this.tsmiXoaNV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.Controls.Add(this.dgvNhanVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1246, 578);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.White;
            this.btnThemNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.Image")));
            this.btnThemNV.Location = new System.Drawing.Point(1176, 508);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(62, 62);
            this.btnThemNV.TabIndex = 10;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(4, 27);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1238, 547);
            this.dgvNhanVien.TabIndex = 8;
            // 
            // tpDuAn
            // 
            this.tpDuAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpDuAn.ContextMenuStrip = this.cmsDuAn;
            this.tpDuAn.Controls.Add(this.groupBox2);
            this.tpDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDuAn.Location = new System.Drawing.Point(4, 29);
            this.tpDuAn.Margin = new System.Windows.Forms.Padding(4);
            this.tpDuAn.Name = "tpDuAn";
            this.tpDuAn.Padding = new System.Windows.Forms.Padding(4);
            this.tpDuAn.Size = new System.Drawing.Size(1254, 586);
            this.tpDuAn.TabIndex = 1;
            this.tpDuAn.Text = "Dự án";
            this.tpDuAn.UseVisualStyleBackColor = true;
            // 
            // cmsDuAn
            // 
            this.cmsDuAn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDuAn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChiTietDA,
            this.tsmiSuaDA,
            this.tsmiKetThucDA});
            this.cmsDuAn.Name = "cmsDuAn";
            this.cmsDuAn.Size = new System.Drawing.Size(182, 76);
            // 
            // tsmiChiTietDA
            // 
            this.tsmiChiTietDA.Name = "tsmiChiTietDA";
            this.tsmiChiTietDA.Size = new System.Drawing.Size(181, 24);
            this.tsmiChiTietDA.Text = "Chi Tiết";
            this.tsmiChiTietDA.Click += new System.EventHandler(this.tsmiChiTietDA_Click);
            // 
            // tsmiSuaDA
            // 
            this.tsmiSuaDA.Name = "tsmiSuaDA";
            this.tsmiSuaDA.Size = new System.Drawing.Size(181, 24);
            this.tsmiSuaDA.Text = "Sửa Thông Tin";
            // 
            // tsmiKetThucDA
            // 
            this.tsmiKetThucDA.Name = "tsmiKetThucDA";
            this.tsmiKetThucDA.Size = new System.Drawing.Size(181, 24);
            this.tsmiKetThucDA.Text = "Kết Thúc Dự Án";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemDA);
            this.groupBox2.Controls.Add(this.dgvDuAn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1246, 578);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách dự án";
            // 
            // btnThemDA
            // 
            this.btnThemDA.BackColor = System.Drawing.Color.White;
            this.btnThemDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemDA.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDA.Image")));
            this.btnThemDA.Location = new System.Drawing.Point(1176, 508);
            this.btnThemDA.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDA.Name = "btnThemDA";
            this.btnThemDA.Size = new System.Drawing.Size(62, 62);
            this.btnThemDA.TabIndex = 10;
            this.btnThemDA.UseVisualStyleBackColor = false;
            this.btnThemDA.Click += new System.EventHandler(this.btnThemDA_Click);
            // 
            // dgvDuAn
            // 
            this.dgvDuAn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuAn.Location = new System.Drawing.Point(4, 27);
            this.dgvDuAn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDuAn.Name = "dgvDuAn";
            this.dgvDuAn.ReadOnly = true;
            this.dgvDuAn.RowHeadersWidth = 51;
            this.dgvDuAn.RowTemplate.Height = 24;
            this.dgvDuAn.Size = new System.Drawing.Size(1238, 547);
            this.dgvDuAn.TabIndex = 8;
            // 
            // tpThongKe
            // 
            this.tpThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpThongKe.Controls.Add(this.groupBox6);
            this.tpThongKe.Controls.Add(this.groupBox5);
            this.tpThongKe.Controls.Add(this.groupBox4);
            this.tpThongKe.Controls.Add(this.groupBox3);
            this.tpThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpThongKe.Location = new System.Drawing.Point(4, 29);
            this.tpThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.tpThongKe.Name = "tpThongKe";
            this.tpThongKe.Padding = new System.Windows.Forms.Padding(4);
            this.tpThongKe.Size = new System.Drawing.Size(1254, 586);
            this.tpThongKe.TabIndex = 2;
            this.tpThongKe.Text = "Thống kê";
            this.tpThongKe.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clbChiNhanh);
            this.groupBox6.Location = new System.Drawing.Point(10, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(617, 132);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chi nhánh";
            // 
            // clbChiNhanh
            // 
            this.clbChiNhanh.CheckOnClick = true;
            this.clbChiNhanh.FormattingEnabled = true;
            this.clbChiNhanh.Location = new System.Drawing.Point(6, 24);
            this.clbChiNhanh.MultiColumn = true;
            this.clbChiNhanh.Name = "clbChiNhanh";
            this.clbChiNhanh.Size = new System.Drawing.Size(605, 92);
            this.clbChiNhanh.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(633, 319);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(620, 287);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lương";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(614, 261);
            this.dataGridView2.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(631, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(620, 309);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lương";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(614, 283);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvLuong);
            this.groupBox3.Location = new System.Drawing.Point(7, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 458);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lương";
            // 
            // dgvLuong
            // 
            this.dgvLuong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuong.Location = new System.Drawing.Point(3, 23);
            this.dgvLuong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.ReadOnly = true;
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.RowTemplate.Height = 24;
            this.dgvLuong.Size = new System.Drawing.Size(614, 432);
            this.dgvLuong.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExit.Image")));
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(116, 26);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateAcc,
            this.tsmiChangePass});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // tsmiCreateAcc
            // 
            this.tsmiCreateAcc.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCreateAcc.Image")));
            this.tsmiCreateAcc.Name = "tsmiCreateAcc";
            this.tsmiCreateAcc.Size = new System.Drawing.Size(207, 26);
            this.tsmiCreateAcc.Text = "Create";
            this.tsmiCreateAcc.Click += new System.EventHandler(this.tsmiCreateAcc_Click);
            // 
            // tsmiChangePass
            // 
            this.tsmiChangePass.Image = ((System.Drawing.Image)(resources.GetObject("tsmiChangePass.Image")));
            this.tsmiChangePass.Name = "tsmiChangePass";
            this.tsmiChangePass.Size = new System.Drawing.Size(207, 26);
            this.tsmiChangePass.Text = "Change Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chi Nhánh:";
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Items.AddRange(new object[] {
            "Tất cả",
            "Đà Lạt",
            "TPHCM"});
            this.cbbChiNhanh.Location = new System.Drawing.Point(553, 3);
            this.cbbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(258, 28);
            this.cbbChiNhanh.TabIndex = 11;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.cbbChiNhanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dự án";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpNhanVien.ResumeLayout(false);
            this.cmsNhanVien.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tpDuAn.ResumeLayout(false);
            this.cmsDuAn.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).EndInit();
            this.tpThongKe.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslUser;
		private System.Windows.Forms.ToolStripStatusLabel tsslChiNhanh;
		private System.Windows.Forms.ToolStripStatusLabel tsslRole;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpNhanVien;
		private System.Windows.Forms.TabPage tpDuAn;
		private System.Windows.Forms.TabPage tpThongKe;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip cmsNhanVien;
		private System.Windows.Forms.ToolStripMenuItem tsmiSuaNV;
		private System.Windows.Forms.ToolStripMenuItem tsmiXoaNV;
		private System.Windows.Forms.ToolStripMenuItem tsmiChuyenCN;
		private System.Windows.Forms.ContextMenuStrip cmsDuAn;
		private System.Windows.Forms.ToolStripMenuItem tsmiChiTietDA;
		private System.Windows.Forms.ToolStripMenuItem tsmiSuaDA;
		private System.Windows.Forms.ToolStripMenuItem tsmiKetThucDA;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvNhanVien;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgvDuAn;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.Button btnThemNV;
		private System.Windows.Forms.Button btnThemDA;
		private System.Windows.Forms.ComboBox cbbChiNhanh;
		private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiCreateAcc;
		private System.Windows.Forms.ToolStripMenuItem tsmiChangePass;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dgvLuong;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.CheckedListBox clbChiNhanh;
	}
}