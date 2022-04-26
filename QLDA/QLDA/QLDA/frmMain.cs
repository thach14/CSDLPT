using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA
{
	public partial class frmMain : Form
	{
		private DataTable dt;
		private int CN = WorkingContext.Instance.CurrentBranchID;
		private string Role = WorkingContext.Instance.CurrentLoginInfo.RoleName;

		public frmMain()
		{
			InitializeComponent();
		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			var kq = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (kq == DialogResult.Yes)
				Application.Exit();
		}

		private void btnThemNV_Click(object sender, EventArgs e)
		{
			frmNhanVien frmNhanVien = new frmNhanVien("Add");
			frmNhanVien.ShowDialog();
			getNV();
		}

		private void btnThemDA_Click(object sender, EventArgs e)
		{
			frmDuAn frmDuAn = new frmDuAn("Add");
			frmDuAn.ShowDialog();
			getDA();
		}

		private void tsmiChiTietDA_Click(object sender, EventArgs e)
		{
			DataRow row = (dgvDuAn.SelectedRows[0].DataBoundItem as DataRowView).Row;
			frmChiTietDA frmChiTietDA = new frmChiTietDA(row["ID"].ToString(), Int32.Parse(row["IDCN"].ToString()));
			frmChiTietDA.ShowDialog();
			getLuong();
		}

		private void tsmiCreateAcc_Click(object sender, EventArgs e)
		{
			frmDangKy frmDK = new frmDangKy();
			frmDK.ShowDialog();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			cbbChiNhanh.Text = cbbChiNhanh.Items[CN].ToString();
			if (Role == "ChuTich")
			{
				tpNhanVien.ContextMenuStrip = null;
				tpDuAn.ContextMenuStrip.Items.Remove(tsmiSuaDA);
				tpDuAn.ContextMenuStrip.Items.Remove(tsmiKetThucDA);
			}
			else if( Role == "QuanLyCN")
            {
				cbbChiNhanh.Enabled = false;
            }
            else
            {
				cbbChiNhanh.Enabled = false;
				tsmiCreateAcc.Enabled = false;
				tpNhanVien.ContextMenuStrip = null;
				tpDuAn.ContextMenuStrip = null;
			}
			tsslChiNhanh.Text += WorkingContext.Instance.CurrentBranch;
			tsslUser.Text += WorkingContext.Instance.CurrentLoginName;
			tsslRole.Text += WorkingContext.Instance.CurrentLoginInfo.RoleName;
			getNV();
			getDA();
			getLuong();
		}
		private void connect(string SqlString, DataGridView dgv)
		{
			dt = new DataTable();
			var connectionName = string.Format("CN{0}", CN);
			var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
			connectionString = string.Format(connectionString, "sa", "sa");
			var connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			var command = new SqlCommand();
			command.Connection = connection;
			command.CommandType = CommandType.Text;
			SqlDataAdapter sda = new SqlDataAdapter(SqlString, connection);
			sda.Fill(dt);
			dgv.DataSource = dt;
			connection.Close();
		}
		private void connect(string SqlString)
		{
			var connectionName = string.Format("CN{0}", CN);
			var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
			connectionString = string.Format(connectionString, "sa", "sa");
			var connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			var command = new SqlCommand(SqlString, connection);
			command.Connection = connection;
			command.Connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public void getNV()
		{
			string SqlString;
			if (cbbChiNhanh.SelectedIndex == 0)
			{
				SqlString = "exec dsNVCT";
				connect(SqlString, dgvNhanVien);
			}
			else if (cbbChiNhanh.SelectedIndex == CN)
			{
				SqlString = "exec dsNVCN";
				connect(SqlString, dgvNhanVien);
			}
			else
			{
				SqlString = "exec LINK.QLDA.[dbo].dsNVCN";
				connect(SqlString, dgvNhanVien);
			}
		}
		private void getDA()
		{
			string SqlString;
			if (cbbChiNhanh.SelectedIndex == 0)
			{
				SqlString = "exec dsDACT";
				connect(SqlString, dgvDuAn);
			}
			else if (cbbChiNhanh.SelectedIndex == CN)
			{
				SqlString = "exec dsDACN";
				connect(SqlString, dgvDuAn);
			}
			else
			{
				SqlString = "exec LINK.QLDA.[dbo].dsDACN";
				connect(SqlString, dgvDuAn);
			}
		}
		private void getLuong()
		{
			string SqlString;
			if (cbbChiNhanh.SelectedIndex == 0)
			{
				SqlString = "exec luongCT";
				connect(SqlString, dgvLuong);
			}
			else if (cbbChiNhanh.SelectedIndex == CN)
			{
				SqlString = "exec luongCN";
				connect(SqlString, dgvLuong);
			}
			else
			{
				SqlString = "exec LINK.QLDA.[dbo].luongCN";
				connect(SqlString, dgvLuong);
			}
		}

		private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
		{
			getNV();
			getDA();
			getLuong();
		}

		private void tsmiSuaNV_Click(object sender, EventArgs e)
		{
			DataRow row = (dgvNhanVien.SelectedRows[0].DataBoundItem as DataRowView).Row;
			frmNhanVien frmNhanVien = new frmNhanVien(row["ID"].ToString());
			frmNhanVien.ShowDialog();
			getNV();
		}

        private void tsmiXoaNV_Click(object sender, EventArgs e)
        {
			DataRow row = (dgvNhanVien.SelectedRows[0].DataBoundItem as DataRowView).Row;
			string sql = String.Format("exec statusNV {0}, 0",row["ID"].ToString());
			connect(sql);
			getNV();
		}

        private void tsmiSuaDA_Click(object sender, EventArgs e)
        {
			DataRow row = (dgvDuAn.SelectedRows[0].DataBoundItem as DataRowView).Row;
			frmDuAn frmDuAn = new frmDuAn(row["ID"].ToString());
			frmDuAn.ShowDialog();
			getDA();
		}

        private void tsmiKetThucDA_Click(object sender, EventArgs e)
        {
			DataRow row = (dgvDuAn.SelectedRows[0].DataBoundItem as DataRowView).Row;
			string sql = String.Format("exec statusDA {0}, 1",row["ID"].ToString());
			connect(sql);
			getDA();
        }
		private void getLuongThang()
		{
			string SqlString;
			if (cbbChiNhanh.SelectedIndex == 0)
			{
				SqlString = String.Format("exec luongThangCT '{0}', '{1}'", dtpFrom.Text, dtpTo.Text);
				connect(SqlString, dgvLuong);
			}
			else if (cbbChiNhanh.SelectedIndex == CN)
			{
				SqlString = String.Format("exec luongThangCN '{0}', '{1}'", dtpFrom.Text, dtpTo.Text); ;
				connect(SqlString, dgvLuong);
			}
			else
			{
				SqlString = String.Format("exec LINK.QLDA.[dbo].luongThangCN '{0}', '{1}'", dtpFrom.Text, dtpTo.Text); ;
				connect(SqlString, dgvLuong);
			}
		}

        private void cbLoc_CheckedChanged(object sender, EventArgs e)
        {
			if (cbLoc.Checked)
			{
				dtpFrom.Enabled = true;
				dtpTo.Enabled = true;
				btnLoc.Enabled = true;
			}
			else
			{
				getLuong();
				dtpFrom.Enabled = false;
				dtpTo.Enabled = false;
				btnLoc.Enabled = false;
			}
		}

        private void btnLoc_Click(object sender, EventArgs e)
        {
			getLuongThang();
        }

        private void tsmiLogOut_Click(object sender, EventArgs e)
        {
			this.Dispose();
			frmDangNhap frmDangNhap = new frmDangNhap();
			frmDangNhap.ShowDialog();
        }
    }
}
