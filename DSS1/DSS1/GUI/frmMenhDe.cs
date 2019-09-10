using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DSS1.OBJS;

namespace DSS1.GUI
{
    public partial class frmMenhDe : Form
    {
        public frmMenhDe()
        {
            InitializeComponent();
        }

        private void DocDuLieu()
        {
            MenhDe md = new MenhDe();
            DataTable tb = md.Tim("");
            if (tb != null && tb.Rows.Count > 0)
            {
                dgvDanhSach.DataSource = tb;
            }
            else
                dgvDanhSach.Rows.Clear();
        }

        private void frmMenhDe_Load(object sender, EventArgs e)
        {
            DocDuLieu();
        }

        private void LamMoi()
        {
            tbTen.Text = "";
            tbMoTa.Text = "";
            tbTen.Focus();
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}
