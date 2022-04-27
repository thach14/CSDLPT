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
    public partial class frmDATG : Form
    {
        private string idNV;
		private DataTable dt;
		private int CN = WorkingContext.Instance.CurrentBranchID;
        public frmDATG(string idNV)
        {
            InitializeComponent();
            this.idNV = idNV;
        }
		private void connect(string SqlString)
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
			dgvDATG.DataSource = dt;
			connection.Close();
		}
		private void frmDATG_Load(object sender, EventArgs e)
        {
			string sql = String.Format("exec datg {0}", idNV);
			connect(sql);
        }
    }
}
