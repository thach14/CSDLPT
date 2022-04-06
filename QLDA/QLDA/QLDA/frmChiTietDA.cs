using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA
{
	public partial class frmChiTietDA : Form
	{
		public frmChiTietDA()
		{
			InitializeComponent();
		}

		private void tsmiPhanCong_Click(object sender, EventArgs e)
		{
			frmPhanCong frmPhanCong = new frmPhanCong();
			frmPhanCong.ShowDialog();
		}

	}
}
