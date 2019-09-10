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

        private void btXoa_Click(object sender, EventArgs e)
        {
            MenhDe md = new MenhDe();
            int ma = int.Parse(dgvDanhSach.SelectedRows[0].Cells["Ma"].Value.ToString());
            md.Xoa(ma);
            DocDuLieu();
            LamMoi();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Bạn phải nhập tên mệnh đề");
                tbTen.Focus();
                return;
            }

            if(String.IsNullOrEmpty(tbMoTa.Text))
            {
                MessageBox.Show("Bạn phải nhập mô tả của mệnh đề");
                tbMoTa.Focus();
                return;
            }

            MenhDe md = new MenhDe();
            if(md.Tim("Ten=N'" + tbTen.Text + "'") != null)
            {
                MessageBox.Show("Mệnh đề này đã tồn tại, bạn không thể thêm");
                tbTen.Focus();
                return;
            }

            md.Them(tbTen.Text, tbMoTa.Text);
            DocDuLieu();
            LamMoi();
            tbTen.Focus();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Bạn phải nhập tên mệnh đề");
                tbTen.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tbMoTa.Text))
            {
                MessageBox.Show("Bạn phải nhập mô tả của mệnh đề");
                tbMoTa.Focus();
                return;
            }

            int ma = int.Parse(dgvDanhSach.SelectedRows[0].Cells["Ma"].Value.ToString());

            MenhDe md = new MenhDe();
            md.Sua(tbTen.Text, ma, tbMoTa.Text);
            DocDuLieu();
            LamMoi();
        }
    }
}
