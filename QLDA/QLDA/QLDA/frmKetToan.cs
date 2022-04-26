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
    public partial class frmKetToan : Form
    {
        private string idPC;
		private int CN = WorkingContext.Instance.CurrentBranchID;
        public frmKetToan(string idPC)
        {
            InitializeComponent();
            this.idPC = idPC;
        }
		private void ketToan(string SqlString)
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

        private void btnOK_Click(object sender, EventArgs e)
        {
			string sql = String.Format("exec themTL {0}, '{1}', {2}", idPC, dtpNgayKT.Text, mudSoGio.Value);
			ketToan(sql);
			this.Dispose();
        }
    }
}
